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

namespace Auto.Applications.Repositories.Tasks {
    public partial class TaskInfoApp : ITaskInfoApp {
        private readonly IMemberIncomeRepository _IMemberIncomeRepository;
        private readonly ITaskInfoRepository _ITaskInfoRepository;
        private readonly IConfiguration _IConfiguration;
        private readonly int _Before;
        private readonly int _After;

        public TaskInfoApp(IMemberIncomeRepository memberIncomeRepository,
                           ITaskInfoRepository taskInfoRepository,
                           IConfiguration configuration) {

            this._IMemberIncomeRepository = memberIncomeRepository;
            this._ITaskInfoRepository = taskInfoRepository;
            this._Before = Convert.ToInt32(_IConfiguration["ExchangeRatio:Before"]);
            this._After = Convert.ToInt32(_IConfiguration["ExchangeRatio:After"]);

        }

        public async Task<bool> AddIncome(TaskItem item) {
            var taskInfo = await _ITaskInfoRepository.SingleAsync(a => a.TaskCode == item.TaskCode && a.IsEnable == 1);
            var flag = false;
            if (taskInfo != null) {
                var taskInfos = new List<TaskInfo>();
                if (!string.IsNullOrEmpty(taskInfo.RelatedTasks)) {
                    var taskCodes = taskInfo.RelatedTasks.Split(',');
                    taskInfos = await _ITaskInfoRepository.Query(a => taskCodes.Contains(a.TaskCode) && a.IsEnable == 1)
                                                          .ToListAsync();
                }
                if (taskInfo.ReadTime > 0) {
                    flag = await AddDefault(taskInfo, taskInfos, item);
                }
                else {

                }

            }
            return flag;
        }

        private async Task<bool> AddDefault(TaskInfo taskInfo, List<TaskInfo> taskInfos, TaskItem item) {
            var thisIncome = new MemberIncome();
            thisIncome.MemberId = item.MemberId;
            thisIncome.TaskCode = item.TaskCode;
            thisIncome.TaskName = taskInfo.TaskName;
            thisIncome.CategoryDay = taskInfo.CategoryDay;
            thisIncome.CategoryFixed = taskInfo.CategoryFixed;
            thisIncome.Title = taskInfo.SaveDesc;
            thisIncome.Beans = (int)taskInfo.Beans;
            thisIncome.CreateTime = System.DateTime.Now;

            if (taskInfo.Beans >= _Before)
                thisIncome.BeansText = $"+{taskInfo.Beans / _Before}元";
            else
                thisIncome.BeansText = $"+{taskInfo.Beans / _Before}绿豆";

            thisIncome.Proportion = $"{_Before}/{_After}";

            thisIncome.Status = 0;
            thisIncome.AuditBy = item.MemberId;
            thisIncome.AuditName = "admin";
            thisIncome.AuditTime = System.DateTime.Now;
            if (taskInfos.Count > 0) {
                taskInfos.ForEach(a => {

                });
            }

            await _IMemberIncomeRepository.AddAsync(thisIncome);

            
            var result = await _IMemberIncomeRepository.SaveChangesAsync();
            return result > 0;
        }
    }
}
