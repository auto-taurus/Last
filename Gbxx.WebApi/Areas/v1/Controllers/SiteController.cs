using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.RedisDto;
using Auto.RedisServices.Repositories;
using Gbxx.WebApi.Areas.v1.Models.Route;
using Gbxx.WebApi.Requests.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

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
        /// 
        /// </summary>
        protected IWebSiteRedis _IWebSiteRedis;
        /// <summary>
        /// 
        /// </summary>
        protected IWebChannelRedis _IWebChannelRedis;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webSiteRedis"></param>
        /// <param name="webChannelRedis"></param>
        public SiteController(
            ILogger<SiteController> logger,
            IWebSiteRedis webSiteRedis,
            IWebChannelRedis webChannelRedis) {
            this._ILogger = logger;
            this._IWebSiteRedis = webSiteRedis;
            this._IWebChannelRedis = webChannelRedis;
        }
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{mark}")]
        [SwaggerResponse(200, "", typeof(SiteDto))]
        public async Task<IActionResult> GetWebSiteAsync(
                                         [FromHeader]String source,
                                         [FromRoute]SiteRoute route) {
            var response = new Response<SiteDto>();
            try {
                var entity = await _IWebSiteRedis.GetAsync(route.mark);
                if (entity != null) {
                    response.Code = true;
                    response.Data = entity;
                }
                else
                    response.Message = "数据不存在！";

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 站点访问信息统计
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("{mark}/Access")]
        public async Task<IActionResult> GetSiteAccessAsync(
                                         [FromHeader]String source,
                                         [FromRoute]SiteRoute route,
                                         [FromQuery]SiteAccessGet item) {
            var response = new Response<Object>();
            try {
                // 渠道访问
                if (!string.IsNullOrEmpty(item.From)) {
                    await _IWebChannelRedis.AddAccessCount(route.mark, item.From);
                }
                // 站点访问
                await _IWebSiteRedis.AddAccessCount(route.mark);
                response.Code = true;

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}