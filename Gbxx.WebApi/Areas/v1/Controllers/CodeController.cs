using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        [HttpGet("{code}/News")]
        public async Task<IActionResult> GetCodeNewsAsync(string mark, string code, int pageIndex = 1, int pageSize = 7) {
            var response = new Response<Object>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}