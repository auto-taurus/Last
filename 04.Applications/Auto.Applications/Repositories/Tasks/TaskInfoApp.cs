using Auto.Applications.Contracts.Tasks;
using Auto.Applications.Modals;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using Auto.Commons.Linq;

namespace Auto.Applications.Repositories.Tasks
{
    public partial class TaskInfoApp : ITaskInfoApp
    {
        private readonly IMemberIncomeRepository _IMemberIncomeRepository;
        private readonly IMemberInfosRepository _IMemberInfosRepository;
        private readonly ITaskInfoRepository _ITaskInfoRepository;
        private readonly IConfiguration _IConfiguration;
        private readonly int _Before;
        private readonly int _After;

        public TaskInfoApp(IMemberIncomeRepository memberIncomeRepository,
                           IMemberInfosRepository memberInfosRepository,
                           ITaskInfoRepository taskInfoRepository,
                           IConfiguration configuration)
        {

            this._IMemberIncomeRepository = memberIncomeRepository;
            this._IMemberInfosRepository = memberInfosRepository;

            this._ITaskInfoRepository = taskInfoRepository;
            this._IConfiguration = configuration;
            this._Before = Convert.ToInt32(_IConfiguration["ExchangeRatio:Before"]);
            this._After = Convert.ToInt32(_IConfiguration["ExchangeRatio:After"]);

        }
        public async Task<bool> AddTask(TaskItem item)
        {
            // 任务信息
            var taskInfo = await _ITaskInfoRepository.FirstOrDefaultAsync(a => a.TaskCode == item.TaskCode && a.IsEnable == 1);
            var flag = false;
            // 签到任务特殊处理
            if (item.TaskCode == "T0008")
            {
                await AddSignIn(item, taskInfo);
                flag = await _IMemberIncomeRepository.SaveChangesAsync() > 0;
            }
            else
            {
                var member = await _IMemberInfosRepository.FirstOrDefaultAsync(a => a.MemberId == item.MemberId);
                // 任务是否存在
                if (taskInfo != null)
                {
                    // 会员当天收入信息
                    var memberIncomes = await _IMemberIncomeRepository.Query(a => a.MemberId == item.MemberId
                                                                                && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd")
                                                                                && a.Status == 0)
                                                                    .OrderBy(a => a.CreateTime)
                                                                    .ToListAsync();
                    if (taskInfo.IsSubset == 1)
                    {
                        // 子集任务(除签到任务，后续有子集的处理过程)

                    }
                    else
                    {

                        // 当前任务
                        var beans = await AddTask(item, null, taskInfo, memberIncomes);
                        //if (beans <= 0)
                        //{
                        //    return false;
                        //}
                        member.Beans += beans;
                        if (!member.BeansTotals.HasValue)
                        {
                            member.BeansTotals = 0;
                        }
                        member.BeansTotals += beans;
                        if (!string.IsNullOrEmpty(taskInfo.RelatedTasks))
                        {
                            // 是否有关联任务（只做二级）
                            var taskCodes = taskInfo.RelatedTasks.Split("∮");
                            // 关联任务列表
                            var tasks = await _ITaskInfoRepository.Query(a => taskCodes.Contains(a.TaskCode) && a.IsEnable == 1)
                                                                  .ToListAsync();
                            if (tasks.Count > 0)
                            {
                                foreach (var task in tasks)
                                {
                                    // 关联任务增加
                                    beans = await AddTask(item, taskInfo, task, memberIncomes);

                                    member.Beans += beans;
                                    member.BeansTotals += beans;
                                }

                            }
                        }
                        _IMemberInfosRepository.Update(member);
                    }
                    flag = await _IMemberIncomeRepository.SaveChangesAsync() > 0;
                }
            }
            return flag;
        }
        /// <summary>
        /// 签到任务特殊处理
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task AddSignIn(TaskItem item, TaskInfo taskInfo)
        {
            var nows = System.DateTime.Now;
            // 今日签到数据
            var memberIncome = await _IMemberIncomeRepository.Query(a => a.TaskCode == item.TaskCode
                                                                  && a.Status == 0
                                                                  && a.MemberId == item.MemberId
                                                                  && a.CreateTime.Value.ToString("yyyy-MM-dd") == nows.ToString("yyyy-MM-dd"))
                                                      .SingleOrDefaultAsync();
            if (memberIncome == null)
                // 昨日签到数据
                memberIncome = await _IMemberIncomeRepository.Query(a => a.TaskCode == item.TaskCode
                                                                   && a.Status == 0
                                                                   && a.MemberId == item.MemberId
                                                                   && a.CreateTime.Value.ToString("yyyy-MM-dd") == nows.AddDays(-1).ToString("yyyy-MM-dd"))
                                                        .SingleOrDefaultAsync();

            var weeks = await _ITaskInfoRepository.Query(a => a.ParentId == taskInfo.TaskId && a.IsEnable == 1)
                                                  .OrderBy(a => a.Sequence)
                                                  .ToListAsync();
            var beans = 0;
            var number = 1;
            if (memberIncome == null)
            {
                var week = weeks.FirstOrDefault();
                beans = week.Beans.Value;
            }
            else if (memberIncome.CreateTime.Value.ToString("yyyy-MM-dd") == nows.AddDays(-1).ToString("yyyy-MM-dd"))
            {
                number += memberIncome.Number.Value;
                beans = weeks[number].Beans.Value;
            }
            if (beans > 0 && number <= taskInfo.UpperNumber)
            {
                var thisIncome = new MemberIncome();
                thisIncome.Number = number;
                await SetModal(item, taskInfo, beans, thisIncome);

                var member = await _IMemberInfosRepository.FirstOrDefaultAsync(a => a.MemberId == item.MemberId);
                member.Beans += beans;
                member.BeansTotals += beans;
                _IMemberInfosRepository.Update(member);
            }
        }
        private async Task<int> AddTask(TaskItem item, TaskInfo parentTask, TaskInfo taskInfo, List<MemberIncome> taskIncomes)
        {
            var parentIncomes = new List<MemberIncome>();
            if (parentTask != null)
            {
                parentIncomes = taskIncomes.Where(a => a.TaskCode == parentTask.TaskCode).ToList();
            }
            var codeIncomes = taskIncomes.Where(a => a.TaskCode == taskInfo.TaskCode).ToList();

            var lastMemberIncome = codeIncomes.LastOrDefault();
            if(lastMemberIncome==null)
            {
                lastMemberIncome = parentIncomes.LastOrDefault();
            }
            // 0.秒数(基础秒数)
            if (taskInfo.Seconds.HasValue)
            {
                // 获取上次阅读数据
                var lastIncomes = codeIncomes.LastOrDefault();
                if (lastIncomes != null)
                {
                    var seconds = System.DateTime.Now.Subtract(lastIncomes.CreateTime.Value).TotalSeconds;
                    if (seconds < taskInfo.Seconds)
                        return 0;
                }
                if (codeIncomes.Sum(a => a.Beans.Value) >= taskInfo.Beans)
                    return 0;
            }
            // 1.是否设置每天首次任务奖励
            var firstBeans = 0;
            if (taskInfo.FirstBeans.HasValue)
            {
                var income = codeIncomes.FirstOrDefault();
                if (income == null)
                    firstBeans = taskInfo.FirstBeans.Value;
            }
            // 随机绿豆
            var randomBeans = 0;

            // 2.是否开启随机奖励
            if (taskInfo.IsRandom == 1)
            {
                randomBeans = new Random().Next(taskInfo.RandomBefore.Value, taskInfo.RandomAfter.Value);
                // 已超过最大限额
                if (firstBeans > 0)
                {
                    if (randomBeans + firstBeans >= taskInfo.Beans)
                    {
                        randomBeans = taskInfo.Beans.Value - firstBeans;
                    }
                }
                else
                {
                    var codeBeans = codeIncomes.Sum(a => a.Beans.Value);
                    if (randomBeans + codeBeans >= taskInfo.Beans)
                        randomBeans = taskInfo.Beans.Value - codeBeans;
                }
            }

            var beans = firstBeans > 0 ? firstBeans : randomBeans;

            #region #region 额外奖励(大部分是关联任务奖励)

            // 3.是否开启上限次数额外奖励
            if (parentIncomes.Count() == 0 && taskInfo.UpperNumber > 0)
            {
                if (codeIncomes.Count + 1 == taskInfo.UpperNumber)
                {
                    beans += taskInfo.UpperBeans.Value;
                }
            }
            // 4.秒数(上限秒数)
            if (taskInfo.UpperSeconds.HasValue)
            {
                // 后期可扩展是否针对父级做验证，当前版本强制针对父级验证，其他验证同样适用。
                var parentSecondsTotals = 0;
                if (parentIncomes.Count > 0)
                {
                    parentSecondsTotals = parentIncomes.Sum(a => a.ReadTime.HasValue ? a.ReadTime.Value : 0);
                }
                var parentSeconds = 0;
                if (parentTask != null)
                    parentSeconds = parentTask.Seconds.Value;

                if (parentSecondsTotals + parentSeconds == taskInfo.UpperSeconds.Value)
                {
                    beans += taskInfo.Beans.Value;
                }
                else if (parentSecondsTotals < taskInfo.UpperSeconds.Value || parentSecondsTotals + parentSeconds > taskInfo.UpperSeconds.Value)
                {
                    return 0;
                }
            }

            if (codeIncomes.Count() != 0&&taskInfo.UpperBeans.HasValue)
                return 0;
            else if (lastMemberIncome.Number != taskInfo.UpperNumber)
            {

                if (!lastMemberIncome.Number.HasValue)
                    lastMemberIncome.Number = 0;
                lastMemberIncome.Number += 1;
                _IMemberIncomeRepository.Update(lastMemberIncome);
                return 0;
            }
            else
            {
                beans += taskInfo.Beans.Value;
            }

            #endregion
            if (beans <= 0)
                beans = taskInfo.Beans.Value;
            await SetModal(item, taskInfo, beans);
            return beans;
        }
        private async Task SetModal(TaskItem item, TaskInfo taskInfo, int beans, MemberIncome thisIncome = null)
        {
            thisIncome = thisIncome == null ? new MemberIncome() : thisIncome;
            thisIncome.MemberId = item.MemberId;
            thisIncome.TaskId = taskInfo.TaskId;
            thisIncome.TaskCode = taskInfo.TaskCode;
            thisIncome.TaskName = taskInfo.TaskName;
            thisIncome.CategoryDay = taskInfo.CategoryDay;
            thisIncome.CategoryFixed = taskInfo.CategoryFixed;
            thisIncome.Title = taskInfo.SaveDesc;
            thisIncome.Beans = beans;
            thisIncome.CreateTime = System.DateTime.Now;
            thisIncome.ReadTime = taskInfo.Seconds;

            var before = Convert.ToDouble(_Before);
            if (beans >= 20000)
                thisIncome.BeansText = $"+{Math.Round(beans / before, 2)}元";
            else
                thisIncome.BeansText = $"+{beans}绿豆";

            thisIncome.Proportion = $"{_Before}/{_After}";

            thisIncome.Status = 0;
            thisIncome.AuditBy = 1;
            thisIncome.AuditName = "admin";
            thisIncome.AuditTime = System.DateTime.Now;

            await _IMemberIncomeRepository.AddAsync(thisIncome);

        }
    }
}
