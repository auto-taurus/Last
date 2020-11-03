using Auto.Applications.Contracts.Tasks;
using Auto.Applications.Modals;
using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Linq;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using Auto.RedisServices;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Models;
using Gbxx.WebApi.Models.Get;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1/Task")]
    public partial class TaskController : AuthorizeController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IRedisStore _IRedisStore;
        /// <summary>
        /// 
        /// </summary>
        protected ITaskInfoApp _ITaskInfoApp;
        /// <summary>
        /// 
        /// </summary>
        protected ITaskInfoRepository _ITaskInfoRepository;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberIncomeRepository _IMemberIncomeRepository;
        /// <summary>
        /// 
        /// </summary>
        protected ISystemDictionaryRepository _ISystemDictionaryRepository;

        public TaskController(ILogger<SiteController> logger,
                              IRedisStore redisStore,
                              ISystemDictionaryRepository systemDictionaryRepository,
                              ITaskInfoRepository taskInfoRepository,
                              IMemberIncomeRepository memberIncomeRepository,
                              ITaskInfoApp taskInfoApp) {
            this._ILogger = logger;
            this._IRedisStore = redisStore;
            this._ISystemDictionaryRepository = systemDictionaryRepository;
            this._ITaskInfoApp = taskInfoApp;
            this._ITaskInfoRepository = taskInfoRepository;
            this._IMemberIncomeRepository = memberIncomeRepository;
        }

        /// <summary>
        /// 获取一周签到任务
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("Weeks")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTaskDayAsync([FromHeader]String source,
                                                         [FromQuery]MemberIdGet item) {
            var response = new Response<Object>();
            var taskCode = "T0008";
            try {

                var taskInfo = await _ITaskInfoRepository.FirstOrDefaultAsync(a => a.TaskCode == taskCode && a.IsEnable == 1);
                if (taskInfo == null) {
                    return NotFound();
                }
                var weeks = await _ITaskInfoRepository.Query(a => a.ParentId == taskInfo.TaskId && a.IsEnable == 1)
                                                      .OrderBy(a => a.Sequence)
                                                      .ToListAsync();
                if (weeks.Count <= 0)
                    return NoContent();
                // 当前日期
                var nows = System.DateTime.Now;
                // 签到天数
                var signNumber = 0;
                // 今日签到数据
                var memberIncome = await _IMemberIncomeRepository.Query(a => a.TaskCode == taskCode
                                                                      && a.Status == 0
                                                                      && a.MemberId == item.MemberId
                                                                      && a.CreateTime.Value.ToString("yyyy-MM-dd") == nows.ToString("yyyy-MM-dd"))
                                                          .SingleOrDefaultAsync();
                if (memberIncome == null)
                    // 昨日签到数据
                    memberIncome = await _IMemberIncomeRepository.Query(a => a.TaskCode == taskCode
                                                                       && a.Status == 0
                                                                       && a.MemberId == item.MemberId
                                                                       && a.CreateTime.Value.ToString("yyyy-MM-dd") == nows.AddDays(-1).ToString("yyyy-MM-dd"))
                                                            .SingleOrDefaultAsync();
                var todaySignin = false;
                if (memberIncome != null) {
                    signNumber = memberIncome.Number.Value;
                    todaySignin = memberIncome.CreateTime.Value.ToString("yyyy-MM-dd") == nows.ToString("yyyy-MM-dd");
                }
                DateTime beforeTime;
                if (signNumber >= 7)
                    beforeTime = System.DateTime.Now;
                else
                    beforeTime = System.DateTime.Now.AddDays(-signNumber);
                var result = new List<Object>();
                for (var i = 0; i < weeks.Count; i++) {
                    var time = beforeTime.AddDays(i);
                    result.Add(new {
                        CreateTime = time.ToString("yyyy-MM-dd"),
                        IsSignin = i < signNumber,
                        Beans = weeks[i].Beans
                    });
                }
                response.Code = true;
                response.Data = new {
                    TodaySignin = todaySignin,
                    Weeks = result
                };
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 日常任务列表（一次性获取）
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("Dailies")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTaskTypeKeysAsync([FromHeader]String source,
                                                         [FromQuery]MemberIdGet item) {
            var response = new Response<Object>();
            try {
                var dists = await _ISystemDictionaryRepository.GetKeyNames("CategoryDay");
                if (dists.Count <= 0)
                    return NoContent();
                var distKeys = dists.Select(a => int.Parse(a.DistKey)).ToList();
                var tasks = await _ITaskInfoRepository.Query(a => distKeys.Contains(a.CategoryDay.Value) && a.IsDisplay == 1 && a.IsEnable == 1)
                                                      .OrderBy(a => a.Sequence)
                                                      .Select(a => new {
                                                          TaskId = a.TaskId,
                                                          TaskName = a.TaskName,
                                                          TaskCode = a.TaskCode,
                                                          Desc = a.Desc,
                                                          Tips = a.Tips,
                                                          CategoryDay = a.CategoryDay,
                                                          UpperNumber = a.UpperNumber.HasValue ? a.UpperNumber : 0,
                                                          AlreadyNumber = a.UpperNumber.HasValue ? a.MemberIncomes.Count(b => b.TaskCode == a.TaskCode && b.MemberId == item.MemberId) : 0,
                                                          UpperBeans = a.UpperBeans.HasValue ? a.UpperBeans : 0
                                                      })
                                                      .ToListAsync();
                response.Code = true;
                response.Data = new {
                    Dists = dists,
                    Tasks = tasks
                };
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 赚钱日报（分类列表 + 总额）
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("Fixeds")]
        [AllowAnonymous]
        public async Task<IActionResult> GetDictionariesAsync([FromHeader]String source,
                                                              [FromQuery]MemberIdGet item) {
            var response = new Response<List<DistTaskResponse>>();
            try {
                var dists = await _ISystemDictionaryRepository.Query(a => a.TypeKey == "CategoryFixed" && a.IsEnable == 1, a => a.Sequence)
                                                              .Select(a => new DistTaskResponse {
                                                                  DistKey = a.DistKey,
                                                                  DistName = a.DistName
                                                              })
                                                              .ToListAsync();
                if (dists.Count > 0) {
                    var ids = dists.Select(a => int.Parse(a.DistKey)).ToList();
                    var groups = await _IMemberIncomeRepository.Query(a => a.MemberId == item.MemberId
                                                                           && ids.Contains(a.CategoryFixed.Value)
                                                                           && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd")
                                                                           && a.Status == 0)
                                                                .GroupBy(a => a.CategoryFixed)
                                                                .Select(a => new DistTaskResponse {
                                                                    DistKey = a.Key.ToString(),
                                                                    Beans = a.Sum(b => b.Beans.HasValue ? b.Beans.Value : 0)
                                                                }).ToListAsync();
                    dists.ForEach(a => {
                        var group = groups.SingleOrDefault(b => b.DistKey == a.DistKey);
                        if (group != null)
                            a.Beans = group.Beans;
                    });
                    response.Code = true;
                    response.Data = dists;
                }
                else
                    return NoContent();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 赚钱日报（详细数据）
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("Fixeds/{distKey}")]
        public async Task<IActionResult> GetTaskDistKeysAsync([FromHeader]String source,
                                                              [FromRoute]RouteDistKey route) {
            var response = new Response<Object>();
            try {
                var distKey = int.Parse(route.distKey);
                var result = await _IMemberIncomeRepository.Query(a => a.MemberId == MemberId
                                                                       && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd")
                                                                       && a.Status == 0
                                                                       && a.CategoryFixed == distKey)
                                                           .OrderByDescending(a => a.CreateTime)
                                                           .Select(a => new {
                                                               a.IncomeId,
                                                               a.TaskName,
                                                               a.TaskCode,
                                                               a.CategoryDay,
                                                               a.CategoryFixed,
                                                               a.BeansText,
                                                               a.Title,
                                                               a.CreateTime
                                                           })
                                                           .ToListAsync();
                if (result.Count <= 0)
                    return NoContent();
                response.Code = true;
                response.Data = result;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 全站任务入口
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpPost("{code}")]
        public async Task<IActionResult> PostTaskInfoAsync([FromHeader]String source,
                                                           [FromRoute]RouteCode route) {
            var response = new Response<Object>();
            try {
                response.Code = await _ITaskInfoApp.AddTask(new TaskItem() {
                    MemberId = MemberId,
                    TaskCode = route.code
                });
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}