using Auto.Commons.ApiHandles.Responses;
using Gbxx.WebApi.Requests;
using Gbxx.WebApi.Requests.Query;
using Gbxx.WebApi.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    /// <summary>
    /// 专栏管理
    /// </summary>
    public class CodeController : DefaultController {
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public CodeController(ILogger<SiteController> logger) {
            this._ILogger = logger;
        }
        /// <summary>
        /// 专栏新闻列表
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="code">专栏code</param>
        /// <param name="args">查询字段</param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListDto>))]
        [HttpGet("{code}/News")]
        public async Task<IActionResult> GetCodeNewsAsync(string mark, string code, [FromQuery]QueryPager args) {
            var response = new Response<List<NewsListDto>>();
            try {

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}