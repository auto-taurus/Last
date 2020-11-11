using Auto.Applications.Contracts.Tasks;
using Auto.Applications.Modals;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using Masuit.Tools.DateTimes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Applications.Repositories.Tasks {
    public class TaskInfoAppv2 : ITaskInfoApp {
        private readonly IMemberIncomeRepository _IMemberIncomeRepository;
        private readonly IMemberInfosRepository _IMemberInfosRepository;
        private readonly ITaskUpperLogRepository _ITaskUpperLogRepository;

        private readonly ITaskInfoRepository _ITaskInfoRepository;
        private readonly ITaskDetailsRepository _ITaskDetailsRepository;
        private readonly ITaskNoviceLogRepository _ITaskNoviceLogRepository;

        private readonly IConfiguration _IConfiguration;
        private readonly int _Before;
        private readonly int _After;
        private string code;
        public TaskInfoAppv2(IMemberIncomeRepository memberIncomeRepository,
                             IMemberInfosRepository memberInfosRepository,
                             ITaskUpperLogRepository taskUpperLogRepository,
                             ITaskInfoRepository taskInfoRepository,
                             ITaskDetailsRepository taskDetailsRepository,
                             IConfiguration configuration,
                             ITaskNoviceLogRepository taskNoviceLogRepository) {

            this._IMemberIncomeRepository = memberIncomeRepository;
            this._IMemberInfosRepository = memberInfosRepository;
            this._ITaskInfoRepository = taskInfoRepository;
            this._ITaskDetailsRepository = taskDetailsRepository;

            this._ITaskUpperLogRepository = taskUpperLogRepository;

            this._ITaskNoviceLogRepository = taskNoviceLogRepository;

            this._IConfiguration = configuration;

            this._Before = Convert.ToInt32(_IConfiguration["ExchangeRatio:Before"]);
            this._After = Convert.ToInt32(_IConfiguration["ExchangeRatio:After"]);
        }
        public async Task<Tuple<bool, String>> AddTasks(string code, TaskItem item) {
            // 任务信息
            var taskInfo = await _ITaskInfoRepository.FirstOrDefaultAsync(a => a.TaskCode == code && a.IsEnable == 1);
            var flag = false;
            var message = "";
            if (taskInfo != null) {
                // 任务时效性处理
                if (taskInfo.IsTimeLimit == 0) {
                    flag = true;
                }
                else if (taskInfo.IsTimeLimit == 1) {
                    if (DateUtil.In(System.DateTime.Now, taskInfo.BeforeTime.Value, taskInfo.AfterTime.Value, RangeMode.Open)) {
                        flag = true;
                    }
                    else {
                        message = "任务已过期！";
                    }
                }
                else {
                    message = "未设置有效时间！";
                }
                if (flag) {
                    // 会员当天收入
                    var memberIncomes = await _IMemberIncomeRepository.Query(a => a.MemberId == item.MemberId
                                                                                  && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd")
                                                                                  && a.Status == 0)
                                                                      .OrderBy(a => a.CreateTime)
                                                                      .ToListAsync();
                    Tuple<bool, string, int> result;
                    switch (code) {
                        case "T0005":
                            result = await SetSign(item, taskInfo, memberIncomes);
                            break;
                        default:
                            result = await SetTask(item, taskInfo, memberIncomes);
                            break;
                    }
                    var beans = 0;
                    if (result.Item1) {
                        beans += result.Item3;
                        if (!string.IsNullOrEmpty(taskInfo.RelatedTasks)) {
                            var relatedTaskCodes = taskInfo.RelatedTasks.Split("∮");
                            // 关联任务列表
                            var relatedTasks = await _ITaskInfoRepository.Query(a => relatedTaskCodes.Contains(a.TaskCode) && a.IsEnable == 1).ToListAsync();
                            foreach (var relateds in relatedTasks) {
                                result = await SetTask(item, relateds, memberIncomes);
                                if (result.Item1)
                                    beans += result.Item3;
                            }
                        }
                        await _IMemberInfosRepository.UpdateBeans(item.MemberId.Value, beans);
                        flag = await _IMemberIncomeRepository.SaveChangesAsync() > 0;
                    }
                    else {
                        flag = false;
                        message = result.Item2;
                    }
                    if (flag)
                        return new Tuple<bool, string>(flag, "");
                    else
                        return new Tuple<bool, string>(flag, string.IsNullOrEmpty(result.Item2) ? "添加任务奖励失败！" : result.Item2);
                }
            }
            return new Tuple<bool, string>(false, message);
        }
        private async Task<Tuple<bool, string, int>> SetTask(TaskItem item, TaskInfo taskInfo, List<MemberIncome> memberIncomes) {
            // 当前任务收入列表
            var codeIncomes = memberIncomes.Where(a => a.TaskCode == taskInfo.TaskCode).ToList();
            if (taskInfo.IsDisposable == 1) {
                if (await _IMemberIncomeRepository.IsExistAsync(a => a.Status == 0 && a.TaskCode == taskInfo.TaskCode && a.MemberId == item.MemberId))
                    return new Tuple<bool, string, int>(false, "当前任务只能执行一次！", 0);
            }
            // fromId
            var fromIds = new List<MemberIncome>();
            if (taskInfo.UpperCount.HasValue) {
                fromIds = codeIncomes.Where(a => a.FromId == item.FromId).ToList();
            }
            // 0.随机豆子（针对所有获取豆子）
            var randomBeans = 0;
            if (taskInfo.IsRandom == 1) {
                // 随机豆子
                randomBeans = new Random().Next(taskInfo.RandomBefore.Value, taskInfo.RandomAfter.Value);
            }
            else if (taskInfo.IsRandom == 2) {
                // 固定豆子
                randomBeans = taskInfo.FixedBeans.Value;
            }
            if (randomBeans > 0) {
                // 当前任务总收益
                var codeBeans = codeIncomes.Sum(a => a.Beans);

                if (codeBeans + randomBeans > taskInfo.MaxBeans)
                    randomBeans = taskInfo.MaxBeans.Value - codeBeans.Value;
            }

            var secondsBeans = 0;
            var secondsMaxBeans = 0;
            var upperBeans = 0;
            var beans = 0;
            var memberIncome = new MemberIncome();
            MemberIncome lastIncomes;
            if (taskInfo.Seconds.HasValue && taskInfo.UpperSeconds.HasValue) {
                lastIncomes = codeIncomes.LastOrDefault();
                // 3.秒数 + 最大秒数
                var seconds = 0.0;
                if (lastIncomes != null) {
                    seconds = System.DateTime.Now.Subtract(lastIncomes.CreateTime.Value).TotalSeconds;
                }
                else seconds = taskInfo.Seconds.Value;
                if (seconds >= taskInfo.Seconds) {
                    secondsBeans = GetSecondsBeans(taskInfo, codeIncomes, fromIds, randomBeans);
                    var secondsTotals = codeIncomes.Sum(a => a.ReadTime.Value);
                    if (secondsBeans > 0) {
                        if (taskInfo.UpperCount.HasValue) {
                            if (fromIds.Count + 1 <= taskInfo.UpperCount) {
                                memberIncome.ReadTime = taskInfo.Seconds;
                                memberIncome.Beans = secondsBeans;
                                memberIncome.Title = taskInfo.MaxBeansDesc;
                                if (secondsTotals + taskInfo.Seconds == taskInfo.UpperSeconds) {
                                    secondsMaxBeans = taskInfo.UpperSecondsBeans.Value;
                                    memberIncome.UpperSecondsBeans = secondsMaxBeans;
                                    memberIncome.Title = taskInfo.UpperSecondsDesc;
                                }
                                await SetModal(item, taskInfo, memberIncome);
                            }
                            else
                                secondsBeans = 0;
                        }
                        else {
                            memberIncome.ReadTime = taskInfo.Seconds;
                            memberIncome.Beans = secondsBeans;
                            memberIncome.Title = taskInfo.MaxBeansDesc;

                            if (secondsTotals + taskInfo.Seconds == taskInfo.UpperSeconds) {
                                secondsMaxBeans = taskInfo.UpperSecondsBeans.Value;
                                memberIncome.UpperSecondsBeans = secondsMaxBeans;
                                memberIncome.Title = taskInfo.UpperSecondsDesc;
                            }
                            await SetModal(item, taskInfo, memberIncome);
                        }
                    }
                }
                else return new Tuple<bool, string, int>(false, $"未到{taskInfo.Seconds}秒！", 0);
            }
            else if (taskInfo.Seconds.HasValue) {
                // 4.秒数
                lastIncomes = codeIncomes.LastOrDefault();
                var seconds = 0.0;
                if (lastIncomes != null) {
                    seconds = System.DateTime.Now.Subtract(lastIncomes.CreateTime.Value).TotalSeconds;
                }
                else seconds = taskInfo.Seconds.Value;

                if (seconds >= taskInfo.Seconds) {
                    secondsBeans = GetSecondsBeans(taskInfo, codeIncomes, fromIds, randomBeans);
                    if (secondsBeans > 0) {
                        if (taskInfo.UpperCount.HasValue) {
                            if (fromIds.Count + 1 <= taskInfo.UpperCount) {
                                memberIncome.Beans = secondsBeans;
                                memberIncome.Title = taskInfo.MaxBeansDesc;

                                await SetModal(item, taskInfo, memberIncome);
                            }
                        }
                        else {
                            memberIncome.Beans = secondsBeans;
                            memberIncome.Title = taskInfo.MaxBeansDesc;

                            await SetModal(item, taskInfo, memberIncome);
                        }
                    }
                }
                else
                    return new Tuple<bool, string, int>(false, $"未到{taskInfo.Seconds}秒！", 0);
            }
            else if (taskInfo.UpperNumber.HasValue) {
                // 5.上限次数奖励
                var upperLogs = _ITaskUpperLogRepository.Query(a => a.MemberId == item.MemberId
                                                                    && a.TaskId == taskInfo.TaskId
                                                                    && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd"))
                                                        .ToList();
                if (upperLogs.Count <= 0) {
                    if (taskInfo.FirstBeans.HasValue)
                        upperBeans = taskInfo.FirstBeans.Value;

                    memberIncome.Beans = upperBeans;
                    memberIncome.Title = taskInfo.MaxBeansDesc;

                    await SetModal(item, taskInfo, memberIncome);

                    await _ITaskUpperLogRepository.AddAsync(new TaskUpperLog() {
                        TaskId = taskInfo.TaskId,
                        MemberId = item.MemberId,
                        NewsId = item.FromId,
                        CreateTime = System.DateTime.Now
                    });
                }
                else {
                    var newsIds = upperLogs.GroupBy(a => a.NewsId).Select(a => a.First().NewsId).ToList();

                    if (newsIds.Count(a => a == item.FromId) <= 0 && newsIds.Count + 1 < taskInfo.UpperNumber) {
                        await _ITaskUpperLogRepository.AddAsync(new TaskUpperLog() {
                            TaskId = taskInfo.TaskId,
                            MemberId = item.MemberId,
                            NewsId = item.FromId,
                            CreateTime = System.DateTime.Now
                        });
                        await _ITaskUpperLogRepository.SaveChangesAsync();
                    }
                    else if (newsIds.Count(a => a == item.FromId) <= 0 && newsIds.Count + 1 == taskInfo.UpperNumber) {
                        await _ITaskUpperLogRepository.AddAsync(new TaskUpperLog() {
                            TaskId = taskInfo.TaskId,
                            MemberId = item.MemberId,
                            NewsId = item.FromId,
                            CreateTime = System.DateTime.Now
                        });
                        upperBeans = taskInfo.UpperBeans.Value;

                        memberIncome.Beans = upperBeans;
                        memberIncome.Title = taskInfo.UpperBeansDesc;

                        await SetModal(item, taskInfo, memberIncome);
                    }
                }
            }
            else if (taskInfo.MaxBeans.HasValue) {
                // 6.默认最大值处理
                beans = taskInfo.MaxBeans.Value;

                memberIncome.Beans = beans;
                memberIncome.Title = taskInfo.MaxBeansDesc;

                await SetModal(item, taskInfo, memberIncome);
            }
            if (secondsBeans > 0 || secondsMaxBeans > 0 || upperBeans > 0 || beans > 0) {
                // 更新新手任务完成状态，只支持一次性任务
                await UpdateTaskNoviceLog(item, taskInfo);

                return new Tuple<bool, string, int>(true, "", secondsBeans + secondsMaxBeans + upperBeans + beans);
            }
            else
                return new Tuple<bool, string, int>(false, "任务奖励为0！", 0);
        }
        private async Task UpdateTaskNoviceLog(TaskItem item, TaskInfo taskInfo) {
            if (taskInfo.IsNoviceTask == 1 && taskInfo.IsDisposable == 1) {
                if (await _ITaskNoviceLogRepository.IsExistAsync(a => a.TaskId == taskInfo.TaskId && a.MemberId == item.MemberId && a.IsEnable == 1)) {
                    await _ITaskNoviceLogRepository.BatchUpdateAsync(a => a.TaskId == taskInfo.TaskId && a.MemberId == item.MemberId,
                        a => new TaskNoviceLog() {
                            IsEnable = 0
                        });
                    if (!await _ITaskNoviceLogRepository.IsExistAsync(a => a.TaskId == taskInfo.TaskId && a.MemberId == item.MemberId && a.IsEnable == 1))
                        await _IMemberInfosRepository.BatchUpdateAsync(a => a.MemberId == item.MemberId, a => new MemberInfos() { IsNoviceTask = 1 });
                }

            }
        }
        private async Task SetModal(TaskItem item, TaskInfo taskInfo, MemberIncome thisIncome = null) {
            thisIncome = thisIncome == null ? new MemberIncome() : thisIncome;
            thisIncome.MemberId = item.MemberId;
            thisIncome.TaskId = taskInfo.TaskId;

            thisIncome.InvitedId = item.InvitedId;
            thisIncome.FromId = item.FromId;
            thisIncome.FromMark = item.FromMark;

            thisIncome.TaskCode = taskInfo.TaskCode;
            thisIncome.TaskName = taskInfo.TaskName;
            thisIncome.CategoryDay = taskInfo.CategoryDay;
            thisIncome.CategoryFixed = taskInfo.CategoryFixed;

            //thisIncome.Title = taskInfo.SaveDesc;
            thisIncome.CreateTime = System.DateTime.Now;
            thisIncome.ReadTime = taskInfo.Seconds;

            var before = Convert.ToDouble(_Before);
            thisIncome.Beans = thisIncome.Beans.HasValue ? thisIncome.Beans.Value : 0;
            thisIncome.UpperSecondsBeans = thisIncome.UpperSecondsBeans.HasValue ? thisIncome.UpperSecondsBeans.Value : 0;
            var beans = thisIncome.Beans.Value + thisIncome.UpperSecondsBeans.Value;

            if (beans >= 20000)
                thisIncome.BeansText = $"+{Math.Round(beans / before, 2)}元";
            else
                thisIncome.BeansText = $"+{ beans }金币";

            thisIncome.Proportion = $"{_Before}/{_After}";

            thisIncome.Status = 0;
            thisIncome.AuditBy = 1;
            thisIncome.AuditName = "admin";
            thisIncome.AuditTime = System.DateTime.Now;
            if (!thisIncome.IsDisplay.HasValue)
                thisIncome.IsDisplay = 1;
            await _IMemberIncomeRepository.AddAsync(thisIncome);
        }
        private int GetSecondsBeans(TaskInfo taskInfo, List<MemberIncome> codeIncomes, List<MemberIncome> fromIds, int randomBeans) {
            var secondsBeans = 0;
            var totalBeans = 0;
            if (codeIncomes.Count <= 0 || fromIds.Count <= 0) {
                if (taskInfo.FirstBeans.HasValue) {
                    secondsBeans = taskInfo.FirstBeans.Value;
                }
                else if (randomBeans > 0) {
                    secondsBeans = randomBeans;
                }
                totalBeans = codeIncomes.Sum(a => a.Beans.Value);
                if (secondsBeans + totalBeans > taskInfo.MaxBeans) {
                    secondsBeans = taskInfo.MaxBeans.Value - totalBeans;
                }
            }
            else {
                totalBeans = codeIncomes.Sum(a => a.Beans.Value);
                if (secondsBeans + totalBeans >= taskInfo.MaxBeans) {
                    secondsBeans = taskInfo.MaxBeans.Value - totalBeans;
                }
                else {
                    secondsBeans = randomBeans;
                }
            }
            return secondsBeans;
        }
        /// <summary>
        /// 签到任务特殊处理
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private async Task<Tuple<bool, string, int>> SetSign(TaskItem item, TaskInfo taskInfo, List<MemberIncome> memberIncomes) {
            var nows = System.DateTime.Now;
            var flag = false;
            var message = "";
            // 今日签到数据
            var memberIncome = memberIncomes.FirstOrDefault(a => a.TaskCode == taskInfo.TaskCode);

            if (memberIncome == null)
                // 昨日签到数据
                memberIncome = await _IMemberIncomeRepository.Query(a => a.TaskCode == taskInfo.TaskCode
                                                                         && a.Status == 0
                                                                         && a.MemberId == item.MemberId
                                                                         && a.CreateTime.Value.ToString("yyyy-MM-dd") == nows.AddDays(-1).ToString("yyyy-MM-dd"))
                                                        .SingleOrDefaultAsync();

            var weeks = await _ITaskDetailsRepository.Query(a => a.TaskId == taskInfo.TaskId && a.IsEnable == 1)
                                                     .OrderBy(a => a.Sequence)
                                                     .ToListAsync();
            var beans = 0;
            var number = 0;
            var week = new TaskDetails();
            // 当天收入
            if (memberIncome == null) {
                week = weeks.FirstOrDefault();
                beans = week.Beans.Value;
            }
            // 昨天收入
            else if (memberIncome.CreateTime.Value.ToString("yyyy-MM-dd") == nows.AddDays(-1).ToString("yyyy-MM-dd")) {
                number += memberIncome.SignNumber.Value;
                week = weeks[number];
                beans = week.Beans.Value;
            }
            if (beans > 0 && number < taskInfo.UpperNumber) {
                var thisIncome = new MemberIncome();
                thisIncome.SignNumber = number + 1;
                thisIncome.Beans = beans;
                thisIncome.Title = week.SaveDesc;
                // 添加签到数据
                await SetModal(item, taskInfo, thisIncome);
                flag = true;
            }
            else {
                flag = false;
                message = "签到失败！";
                beans = 0;
            }
            return new Tuple<bool, string, int>(flag, message, beans);
        }
    }
}
