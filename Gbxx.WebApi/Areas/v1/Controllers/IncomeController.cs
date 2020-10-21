﻿using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
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
        [SwaggerResponse(200, "", typeof(IList<MemberIncomeAppDto>))]
        public async Task<IActionResult> GetMemberIncomesAsync([FromHeader]String source,
                                                               [FromRoute]IdIntRoute route,
                                                               [FromQuery]PagerBase item) {
            var response = new Response<IList<MemberIncomeAppDto>>();
            try {
                var result = await _IMemberIncomeRepository.GetAppPagerAsync(a => a.MemberId == route.id, item.PageIndex.Value, item.PageSize.Value);
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
        /// <returns></returns>
        [HttpGet("{id}/Reads")]
        public async Task<IActionResult> GetMemberReadSumsAsync([FromHeader]String source,
                                                                [FromRoute]IdIntRoute route) {
            var response = new Response<object>();
            try {
                response.Code = true;
                response.Data = await _IMemberIncomeRepository.Query(a => a.MemberId == route.id
                                                                          && a.TaskCode == "T0003"
                                                                          && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd")
                                                                          && a.Status == 0)
                                                              .SumAsync(a => a.ReadTime);
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 单独获取当天获得绿豆数
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Beans")]
        public async Task<IActionResult> GetMemberBeansSumsAsync([FromHeader]String source,
                                                                 [FromRoute]IdIntRoute route) {
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