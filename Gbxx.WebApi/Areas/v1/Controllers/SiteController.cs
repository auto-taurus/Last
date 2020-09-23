using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.RedisDto;
using Gbxx.WebApi.Requests.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    /// <summary>
    /// 站点管理
    /// </summary>
    [Route("v1/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class SiteController : ControllerBase {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 站点管理
        /// </summary>
        /// <param name="logger"></param>
        public SiteController(ILogger<SiteController> logger) {
            this._ILogger = logger;
        }
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        [HttpGet("{mark}")]
        public async Task<IActionResult> GetWebSiteAsync(string mark) {
            var response = new Response<SiteDto>();
            try {
                var entityWebSite = new SiteDto();
                entityWebSite.SiteId = 1;
                response.Data = entityWebSite;
                response.Code = true;
                await Task.Run(() => entityWebSite = new SiteDto());
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 站点访问信息统计
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <returns></returns>
        [HttpGet("{mark}/Access")]
        public async Task<IActionResult> GetSiteAccessAsync([FromQuery]SiteAccessQuery item) {
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