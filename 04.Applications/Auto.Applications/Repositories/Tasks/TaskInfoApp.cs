using Auto.Applications.Contracts.Tasks;
using Auto.Applications.Modals;
using Auto.Commons.Ioc.IContract;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using Masuit.Tools.DateTimes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto.Applications.Repositories.Tasks {
    public partial class TaskInfoApp : ITaskInfoApp, INeedInjectNot {
        private readonly IMemberIncomeRepository _IMemberIncomeRepository;
        private readonly IMemberInfosRepository _IMemberInfosRepository;
        private readonly ITaskInfoRepository _ITaskInfoRepository;
        private readonly IConfiguration _IConfiguration;
        private readonly int _Before;
        private readonly int _After;
        private string code;
        public TaskInfoApp(IMemberIncomeRepository memberIncomeRepository,
                           IMemberInfosRepository memberInfosRepository,
                           ITaskInfoRepository taskInfoRepository,
                           IConfiguration configuration) {

            this._IMemberIncomeRepository = memberIncomeRepository;
            this._IMemberInfosRepository = memberInfosRepository;

            this._ITaskInfoRepository = taskInfoRepository;
            this._IConfiguration = configuration;
            this._Before = Convert.ToInt32(_IConfiguration["ExchangeRatio:Before"]);
            this._After = Convert.ToInt32(_IConfiguration["ExchangeRatio:After"]);

        }

        public async Task<Tuple<bool, String,int>> AddTasks(string code, TaskItem item) {
            //// 任务信息
            //var taskInfo = await _ITaskInfoRepository.FirstOrDefaultAsync(a => a.TaskCode == code && a.IsEnable == 1);
            var flag = false;
            var message = "";
            //// 任务存在
            //if (taskInfo != null) {
            //    // 任务时效性处理
            //    if (taskInfo.IsTime == 0) {
            //        flag = true;
            //    }
            //    else if (taskInfo.IsTime == 1) {
            //        if (DateUtil.In(System.DateTime.Now, taskInfo.BeforeTime.Value, taskInfo.AfterTime.Value, RangeMode.Open)) {
            //            flag = true;
            //        }
            //    }
            //    else {
            //        message = "未设置有效时间！";
            //    }
            //    if (flag) {
            //        // 会员当天收入
            //        var memberIncomes = await _IMemberIncomeRepository.Query(a => a.MemberId == item.MemberId && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd") && a.Status == 0)
            //                                                          .OrderBy(a => a.CreateTime)
            //                                                          .ToListAsync();
            //        Tuple<bool, string, int> result;
            //        switch (taskInfo.TaskCode) {
            //            case "T0008":
            //                result = await SetSign(item, taskInfo);
            //                flag = false;
            //                break;
            //            default:
            //                flag = true;
            //                result = await AddTasks(item, taskInfo, memberIncomes);
            //                break;
            //        }
            //        if (result.Item1) {
            //            // 同步用户总额
            //            flag = await _IMemberIncomeRepository.SaveChangesAsync() > 0;
            //            return new Tuple<bool, string>(flag, "");
            //        }
            //        else {
            //            // 任务添加失败
            //            return new Tuple<bool, string>(result.Item1, result.Item2);
            //        }
            //    }
            //}
            return new Tuple<bool, string,int>(flag, message,0);
        }
        //private async Task<Tuple<bool, string, int>> AddTasks(TaskItem item, TaskInfo taskInfo, List<MemberIncome> memberIncomes) {
        //    var result = await SetTasks(item, taskInfo, memberIncomes);
        //    if (result.Item1) {
        //        // 关联任务处理
        //        if (!string.IsNullOrEmpty(taskInfo.RelatedTasks)) {
        //            // 是否有关联任务（只做二级）
        //            var relatedTaskCodes = taskInfo.RelatedTasks.Split("∮");
        //            // 关联任务列表
        //            var relatedTasks = await _ITaskInfoRepository.Query(a => relatedTaskCodes.Contains(a.TaskCode) && a.IsEnable == 1).ToListAsync();
        //            if (relatedTasks.Count > 0) {
        //                foreach (var task in relatedTasks) {
        //                    // 关联任务增加
        //                    var resultRelated = await SetTasks(item, task, memberIncomes);
        //                    if (!resultRelated.Item1)
        //                        break;
        //                    //member.Beans += beans;
        //                    //member.BeansTotals += beans;
        //                }
        //            }
        //        }
        //    }
        //    return new Tuple<bool, string, int>(result.Item1, result.Item2, 1);
        //}
        //private async Task<Tuple<bool, string, int>> SetTasks(TaskItem item, TaskInfo taskInfo, List<MemberIncome> memberIncomes) {
        //    // 当前任务收入列表
        //    var codeIncomes = memberIncomes.Where(a => a.TaskCode == taskInfo.TaskCode).ToList();
        //    // 当前任务收入
        //    var codeIncome = memberIncomes.Where(a => a.TaskCode == taskInfo.TaskCode).FirstOrDefault();
        //    // 总豆子
        //    var beansTotals = codeIncomes.Sum(a => a.Beans.Value);
        //    // 是否已存在内容收益
        //    var fromIdCount = codeIncomes.Where(a => a.IsDisplay == 0).GroupBy(a => a.FromId).Count();
        //    // 0.随机豆子（针对所有获取豆子）
        //    var randomBeans = 0;
        //    if (taskInfo.IsRandom == 0) {
        //        // 固定豆子
        //        randomBeans = taskInfo.FixedBeans.Value;
        //    }
        //    else if (taskInfo.IsRandom == 1) {
        //        // 随机豆子
        //        randomBeans = new Random().Next(taskInfo.RandomBefore.Value, taskInfo.RandomAfter.Value);
        //    }
        //    if (randomBeans > 0) {
        //        // 总豆子处理随机豆子
        //        var codeBeans = codeIncomes.Sum(a => a.Beans.Value);
        //        if (codeBeans + randomBeans > taskInfo.Beans)
        //            randomBeans = taskInfo.Beans.Value - codeBeans;
        //    }
        //    // 1.开启首次任务奖励
        //    var firstBeans = 0;
        //    if (taskInfo.FirstBeans.HasValue) {
        //        if (codeIncomes.Count <= 0 || codeIncomes.Count(a => a.FromId == item.FromId) <= 0)
        //            firstBeans = taskInfo.FirstBeans.Value;
        //    }
        //    var memberIncome = new MemberIncome();
        //    // 2.开启上限次数额外奖励（秒数奖励和上限次数奖励不能同时开启,只能通过关联任务来做处理）
        //    if (taskInfo.UpperNumber > 0) {

        //        if (codeIncome == null || fromIdCount + 1 < taskInfo.UpperNumber) {
        //            memberIncome.Beans = 0;
        //            memberIncome.Number = 1;
        //            memberIncome.BeansText = taskInfo.BeansText;
        //            memberIncome.IsDisplay = 0;
        //            await SetModal(item, taskInfo, memberIncome);
        //        }
        //        if (fromIdCount + 1 == taskInfo.UpperNumber) {
        //            memberIncome.Beans = taskInfo.UpperBeans;
        //            memberIncome.Number = taskInfo.UpperNumber;
        //            memberIncome.BeansText = taskInfo.BeansText;
        //            memberIncome.IsDisplay = 1;
        //            await SetModal(item, taskInfo, memberIncome);
        //            //// 默认情况下条数对应1
        //            //var number = codeIncomes.Sum(a => a.Number.Value);
        //            //// 当前已收入数量+1是否等于上限数量
        //            //if (number + 1 < taskInfo.UpperNumber) {
        //            //    number += 1;
        //            //    await _IMemberIncomeRepository.BatchUpdateAsync(a => a.IncomeId == codeIncome.IncomeId,
        //            //                                                         a => new MemberIncome() { Number = number });
        //            //}
        //            //else if (number + 1 == taskInfo.UpperNumber) {
        //            //    await _IMemberIncomeRepository.BatchUpdateAsync(a => a.IncomeId == codeIncome.IncomeId,
        //            //                                                         a => new MemberIncome() {
        //            //                                                             Number = taskInfo.UpperNumber,
        //            //                                                             Beans = taskInfo.UpperBeans.Value,
        //            //                                                             CreateTime = System.DateTime.Now,
        //            //                                                             AuditTime = System.DateTime.Now
        //            //                                                         });
        //            //}
        //        }
        //    }
        //    else if (taskInfo.Seconds.HasValue && taskInfo.UpperSeconds.HasValue) {
        //        // 基础秒数奖励 + 上限秒数奖励
        //        // 获取上次阅读数据
        //        var lastIncomes = codeIncomes.LastOrDefault();
        //        var secondsBeans = firstBeans > 0 ? firstBeans : randomBeans;
        //        // 任务最后一次基础秒数判断
        //        if (lastIncomes != null) {
        //            var seconds = System.DateTime.Now.Subtract(lastIncomes.CreateTime.Value).TotalSeconds;
        //            // 大于等于30秒（自定义）
        //            //if (seconds >= taskInfo.Seconds) {
        //            // 开启基础秒数奖励，必须同时开随机选项
        //            var secondsTotal = codeIncomes.Sum(a => a.ReadTime);
        //            if (beansTotals + secondsBeans > taskInfo.Beans)
        //                secondsBeans = taskInfo.Beans.Value - beansTotals;
        //            // 上限处理
        //            if (secondsTotal + taskInfo.Seconds == taskInfo.UpperSeconds) {
        //                memberIncome.Beans = secondsBeans;
        //                memberIncome.BeansExtra = taskInfo.UpperSecondsBeans;
        //                memberIncome.BeansText = string.IsNullOrEmpty(taskInfo.UpperSecondsDesc) ? taskInfo.SaveDesc : taskInfo.UpperSecondsDesc;
        //            }
        //            else if (beansTotals < taskInfo.Beans) {
        //                if (beansTotals + secondsBeans > taskInfo.Beans)
        //                    secondsBeans = taskInfo.Beans.Value - beansTotals;
        //                memberIncome.Beans = secondsBeans;
        //                memberIncome.BeansText = taskInfo.SaveDesc;
        //            }
        //            //}
        //        }
        //        else {
        //            //if (seconds >= taskInfo.Seconds) {
        //            // 上限处理
        //            if (taskInfo.Seconds == taskInfo.UpperSeconds) {
        //                memberIncome.Beans = secondsBeans;
        //                memberIncome.BeansExtra = taskInfo.UpperSecondsBeans;
        //                memberIncome.BeansText = string.IsNullOrEmpty(taskInfo.UpperSecondsDesc) ? taskInfo.SaveDesc : taskInfo.UpperSecondsDesc;
        //            }
        //            else if (beansTotals < taskInfo.Beans) {
        //                if (beansTotals + secondsBeans > taskInfo.Beans)
        //                    secondsBeans = taskInfo.Beans.Value - beansTotals;
        //                memberIncome.Beans = secondsBeans;
        //                memberIncome.BeansText = taskInfo.SaveDesc;
        //            }
        //            //}
        //        }
        //    }
        //    var beans = (memberIncome.Beans.HasValue ? memberIncome.Beans.Value : 0) + (memberIncome.BeansExtra.HasValue ? memberIncome.BeansExtra.Value : 0);
        //    if (beans > 0) {
        //        await SetModal(item, taskInfo, memberIncome);
        //        return new Tuple<bool, string, int>(true, "", beans);
        //    }
        //    else
        //        return new Tuple<bool, string, int>(false, "任务奖励为0！", 0);
        //}
        ///// <summary>
        ///// 签到任务特殊处理
        ///// </summary>
        ///// <param name="item"></param>
        ///// <returns></returns>
        //public async Task<Tuple<bool, string, int>> SetSign(TaskItem item, TaskInfo taskInfo) {
        //    var nows = System.DateTime.Now;
        //    var flag = false;
        //    var message = "";
        //    // 今日签到数据
        //    var memberIncome = await _IMemberIncomeRepository.Query(a => a.TaskCode == taskInfo.TaskCode
        //                                                                && a.Status == 0
        //                                                                && a.MemberId == item.MemberId
        //                                                                && a.CreateTime.Value.ToString("yyyy-MM-dd") == nows.ToString("yyyy-MM-dd"))
        //                                              .SingleOrDefaultAsync();
        //    if (memberIncome == null)
        //        // 昨日签到数据
        //        memberIncome = await _IMemberIncomeRepository.Query(a => a.TaskCode == taskInfo.TaskCode
        //                                                                 && a.Status == 0
        //                                                                 && a.MemberId == item.MemberId
        //                                                                 && a.CreateTime.Value.ToString("yyyy-MM-dd") == nows.AddDays(-1).ToString("yyyy-MM-dd"))
        //                                                .SingleOrDefaultAsync();

        //    var weeks = await _ITaskInfoRepository.Query(a => a.ParentId == taskInfo.TaskId && a.IsEnable == 1)
        //                                          .OrderBy(a => a.Sequence)
        //                                          .ToListAsync();
        //    var beans = 0;
        //    var number = 1;
        //    if (memberIncome == null) {
        //        var week = weeks.FirstOrDefault();
        //        beans = week.Beans.Value;
        //    }
        //    else if (memberIncome.CreateTime.Value.ToString("yyyy-MM-dd") == nows.AddDays(-1).ToString("yyyy-MM-dd")) {
        //        number += memberIncome.Number.Value;
        //        beans = weeks[number].Beans.Value;
        //    }
        //    if (beans > 0 && number <= taskInfo.UpperNumber) {
        //        var thisIncome = new MemberIncome();
        //        thisIncome.Number = number;
        //        // 添加签到数据
        //        await SetModal(item, taskInfo, thisIncome);
        //        // 同步用户数据
        //        var member = await _IMemberInfosRepository.FirstOrDefaultAsync(a => a.MemberId == item.MemberId);
        //        member.Beans += beans;
        //        member.BeansTotals += beans;
        //        _IMemberInfosRepository.Update(member);
        //        flag = true;
        //    }
        //    else {
        //        message = "";
        //    }
        //    return new Tuple<bool, string, int>(true, "", 1);
        //}
        //private async Task SetModal(TaskItem item, TaskInfo taskInfo, MemberIncome thisIncome = null) {
        //    thisIncome = thisIncome == null ? new MemberIncome() : thisIncome;
        //    thisIncome.MemberId = item.MemberId;
        //    thisIncome.TaskId = taskInfo.TaskId;

        //    thisIncome.InvitedId = item.InvitedId;
        //    thisIncome.FromId = item.FromId;
        //    thisIncome.FromMark = item.FromMark;

        //    thisIncome.TaskCode = taskInfo.TaskCode;
        //    thisIncome.TaskName = taskInfo.TaskName;
        //    thisIncome.CategoryDay = taskInfo.CategoryDay;
        //    thisIncome.CategoryFixed = taskInfo.CategoryFixed;
        //    thisIncome.Title = taskInfo.SaveDesc;
        //    thisIncome.CreateTime = System.DateTime.Now;
        //    thisIncome.ReadTime = taskInfo.Seconds;

        //    var before = Convert.ToDouble(_Before);
        //    if (thisIncome.Beans >= 20000)
        //        thisIncome.BeansText = $"+{Math.Round(thisIncome.Beans.Value / before, 2)}元";
        //    else
        //        thisIncome.BeansText = $"+{ thisIncome.Beans}金币";

        //    thisIncome.Proportion = $"{_Before}/{_After}";

        //    thisIncome.Status = 0;
        //    thisIncome.AuditBy = 1;
        //    thisIncome.AuditName = "admin";
        //    thisIncome.AuditTime = System.DateTime.Now;
        //    if (!thisIncome.IsDisplay.HasValue)
        //        thisIncome.IsDisplay = 1;


        //    await _IMemberIncomeRepository.AddAsync(thisIncome);
        //}
    }
}
