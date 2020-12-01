using Auto.Commons.ApiHandles.Responses;
using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1/Member")]
    public class IncomeController : AuthorizeController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberInfosRepository _IMemberInfoRepository;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberIncomeRepository _IMemberIncomeRepository;
        public IncomeController(ILogger<SiteController> logger,
                                IMemberInfosRepository memberInfoRepository,
                                IMemberIncomeRepository memberIncomeRepository) {
            this._ILogger = logger;
            this._IMemberInfoRepository = memberInfoRepository;
            this._IMemberIncomeRepository = memberIncomeRepository;

        }
        /// <summary>
        /// 获取会员收入记录列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("{id}/Incomes")]
        public async Task<IActionResult> GetMemberIncomesAsync([FromHeader]String source,
                                                               [FromRoute]RouteIdInt route,
                                                               [FromQuery]RoutePageCode item) {
            var response = new Response<Object>();
            try {
                Expression<Func<MemberIncome, bool>> expression;
                if (!string.IsNullOrEmpty(item.code)) {
                    //查询不同code
                    expression = a => a.MemberId == route.id && a.TaskCode == item.code && a.Status == 0 && a.IsDisplay == 1 && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd");
                }
                else if(item.todayFlag) {
                    //查询今日
                    expression = a => a.MemberId == route.id&& a.Status == 0 && a.IsDisplay == 1 && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd");
                }
                else {
                    expression = a => a.MemberId == route.id && a.Status == 0 && a.IsDisplay == 1;//查询所有
                }
                var result = await _IMemberIncomeRepository.Query(expression)
                                                           .OrderByDescending(a => a.CreateTime)
                                                           .ToPager(item.PageIndex.Value, item.PageSize.Value)
                                                           .Select(a => new {
                                                               a.IncomeId,
                                                               a.TaskName,
                                                               a.CategoryDay,
                                                               a.CategoryFixed,
                                                               a.BeansText,
                                                               a.Title,
                                                               a.CreateTime
                                                           })
                                                           .ToListAsync();
                if (result.Count > 0) {
                    response.Code = true;
                    response.Data = result;
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
        /// 获取当天向前7天的收入金币记录总额，按天算
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/WeekIncomes")]
        public async Task<IActionResult> GetMemberWeekIncomesAsync([FromHeader]String source,
                                                                   [FromRoute]RouteIdInt route) {
            var response = new Response<Object>();
            try {
                var day = Convert.ToDateTime(System.DateTime.Now.AddDays(-6).ToString("yyyy-MM-dd 00:00:00"));
                var result = await _IMemberIncomeRepository.Query(a => a.MemberId == route.id && a.CreateTime >= day && a.Status == 0)
                                                           .GroupBy(a => a.CreateTime.Value.ToString("yyyy-MM-dd"))
                                                           .OrderByDescending(a => a.First().CreateTime.Value.ToString("yyyy-MM-dd"))
                                                           .Select(a => new {
                                                               CreateTime = a.Key,
                                                               Beans = a.Sum(b => b.Beans)
                                                           }).ToListAsync();
                if (result.Count > 0) {
                    response.Code = true;
                    response.Data = result;
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
        /// 单独获取当天阅读分钟数
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("{id}/Reads")]
        public async Task<IActionResult> GetMemberReadSumsAsync([FromHeader]String source,
                                                                [FromRoute]RouteIdInt route,
                                                                [FromQuery] RouteCode item) {
            var response = new Response<object>();
            try {
                response.Code = true;
                response.Data = await _IMemberIncomeRepository.Query(a => a.MemberId == route.id
                                                                          && a.TaskCode == item.code
                                                                          && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd")
                                                                          && a.Status == 0)
                                                              .SumAsync(a => a.ReadTime) / 60;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 单独获取当天获得金币数
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Beans")]
        public async Task<IActionResult> GetMemberBeansSumsAsync([FromHeader]String source,
                                                                 [FromRoute]RouteIdInt route) {
            var response = new Response<object>();
            try {
                response.Code = true;
                response.Data = await _IMemberIncomeRepository.Query(a => a.MemberId == route.id
                                                                     && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd")
                                                                     && a.Status == 0)
                                                              .SumAsync(a => a.Beans);
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}