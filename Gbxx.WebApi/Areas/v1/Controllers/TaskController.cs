using Auto.Applications.Contracts.Tasks;
using Auto.Applications.Modals;
using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Auto.RedisServices;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models.Post;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Models;
using Gbxx.WebApi.Models.Get;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        protected ITaskDetailsRepository _ITaskDetailsRepository;
        /// <summary>
        /// 
        /// </summary>
        protected ITaskNoviceLogRepository _ITaskNoviceLogRepository;
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
                              ITaskDetailsRepository taskDetailsRepository,
                              IMemberIncomeRepository memberIncomeRepository,
                              ITaskNoviceLogRepository taskNoviceLogRepository,
                              ITaskInfoApp taskInfoApp) {
            this._ILogger = logger;
            this._IRedisStore = redisStore;
            this._ISystemDictionaryRepository = systemDictionaryRepository;
            this._ITaskInfoApp = taskInfoApp;
            this._ITaskInfoRepository = taskInfoRepository;
            this._ITaskDetailsRepository = taskDetailsRepository;
            this._ITaskNoviceLogRepository = taskNoviceLogRepository;
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
            var taskCode = "T0005";
            try {
                var taskInfo = await _ITaskInfoRepository.FirstOrDefaultAsync(a => a.TaskCode == taskCode && a.IsEnable == 1);
                if (taskInfo == null) {
                    return NotFound();
                }
                var weeks = await _ITaskDetailsRepository.Query(a => a.TaskId == taskInfo.TaskId && a.IsEnable == 1)
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
                    signNumber = memberIncome.SignNumber.Value;
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
        /// 新手任务
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("Novice")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTaskNovicesAsync([FromHeader]String source,
                                                             [FromQuery]MemberIdGet item) {
            var response = new Response<Object>();
            try {
                if (await _ITaskNoviceLogRepository.IsExistAsync(a => a.MemberId == item.MemberId && a.IsEnable == 1)) {
                    var noviceLogIds = await _ITaskNoviceLogRepository.Query(a => a.MemberId == item.MemberId && a.CategoryDay == 1 && a.IsEnable == 1)
                                                                      .Select(a => a.TaskId)
                                                                      .ToListAsync();

                    var tasks = await _ITaskInfoRepository.Query(a => noviceLogIds.Contains(a.TaskId)
                                                                      && a.IsDisplay == 1
                                                                      && a.IsEnable == 1)
                                                          .OrderBy(a => a.Sequence)
                                                          .Select(a => new {
                                                              TaskId = a.TaskId,
                                                              TaskName = a.TaskName,
                                                              TaskCode = a.TaskCode,
                                                              ShowDesc = a.ShowDesc,
                                                              BeansText = a.BeansText,
                                                              Tips = a.Tips,
                                                              CategoryDay = a.CategoryDay,
                                                              IconType = a.IconType,
                                                              JumpType = a.JumpType,
                                                              JumpTitle = a.JumpTitle,
                                                              JumpUrl = a.JumpUrl,
                                                              AlreadyNumber = a.UpperNumber.HasValue ? a.MemberIncomes.Count(b => b.TaskCode == a.TaskCode && b.MemberId == item.MemberId) : (a.UpperSeconds.HasValue ? a.MemberIncomes.Sum(b => b.ReadTime) / 60 : 0),
                                                              UpperNumber = a.UpperNumber.HasValue ? a.UpperNumber : (a.UpperSeconds.HasValue ? a.UpperSeconds / 60 : 0),
                                                              UpperBeans = a.UpperBeans.HasValue ? a.UpperBeans : (a.UpperSeconds.HasValue ? a.UpperSecondsBeans : 0)
                                                          })
                                                          .ToListAsync();
                    response.Code = true;
                    response.Data = tasks;
                }
                else {
                    return NoContent();
                }
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
                dists.RemoveAt(dists.FindIndex(a => a.DistKey == "1"));
                var distKeys = dists.Select(a => int.Parse(a.DistKey)).ToList();
                var tasks = await _ITaskInfoRepository.Query(a => distKeys.Contains(a.CategoryDay.Value)
                                                                  && a.IsNoviceTask != 1
                                                                  && a.IsDisplay == 1
                                                                  && a.IsEnable == 1)
                                                      .OrderBy(a => a.Sequence)
                                                      .Select(a => new {
                                                          TaskId = a.TaskId,
                                                          TaskName = a.TaskName,
                                                          TaskCode = a.TaskCode,
                                                          ShowDesc = a.ShowDesc,
                                                          BeansText = a.BeansText,
                                                          Tips = a.Tips,
                                                          CategoryDay = a.CategoryDay,
                                                          IconType = a.IconType,
                                                          JumpType = a.JumpType,
                                                          JumpTitle = a.JumpTitle,
                                                          JumpUrl = a.JumpUrl,
                                                          AlreadyNumber = a.UpperNumber.HasValue ? a.MemberIncomes.Count(b => b.TaskCode == a.TaskCode && b.MemberId == item.MemberId) : (a.UpperSeconds.HasValue ? a.MemberIncomes.Where( b=> b.TaskCode == a.TaskCode && b.MemberId == item.MemberId).Sum(b => b.ReadTime) / 60 : 0),
                                                          UpperNumber = a.UpperNumber.HasValue ? a.UpperNumber : (a.UpperSeconds.HasValue ? a.UpperSeconds / 60 : 0),
                                                          UpperBeans = a.UpperBeans.HasValue ? a.UpperBeans : (a.UpperSeconds.HasValue ? a.UpperSecondsBeans : 0)
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
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("{code}")]
        public async Task<IActionResult> PostTaskInfoAsync([FromHeader]String source,
                                                           [FromRoute]RouteCode route,
                                                           [FromBody]TaskItem item) {
            var response = new Response<Object>();
            try {
                var result = await _ITaskInfoApp.AddTasks(route.code, item);
                response.Code = result.Item1;
                response.Message = result.Item2;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}