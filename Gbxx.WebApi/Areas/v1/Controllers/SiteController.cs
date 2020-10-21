using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Auto.RedisServices.Entities;
using Auto.RedisServices.Repositories;
using Gbxx.WebApi.Areas.v1.Models.Route;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Requests.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    /// <summary>
    /// 站点管理
    /// </summary>
    [Route("v1/[controller]")]
    public class SiteController : DefaultController {
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
        protected IWebSiteRepository _IWebSiteRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webSiteRedis"></param>
        /// <param name="webChannelRedis"></param>
        /// <param name="webSiteRepository"></param>
        public SiteController(
            ILogger<SiteController> logger,
            IWebSiteRedis webSiteRedis,
            IWebChannelRedis webChannelRedis,
            IWebSiteRepository webSiteRepository) {
            this._ILogger = logger;
            this._IWebSiteRedis = webSiteRedis;
            this._IWebChannelRedis = webChannelRedis;
            this._IWebSiteRepository = webSiteRepository;
        }
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{mark}")]
        //[SwaggerResponse(200, "", typeof(WebSiteValue))]
        [ProducesResponseType(typeof(WebSiteValue), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetWebSiteAsync(
                                         [FromHeader]String source,
                                         [FromRoute]SiteRoute route) {
            var response = new Response<WebSiteValue>();
            try {
                var entity = await _IWebSiteRedis.GetAsync(route.mark);
                if (entity != null) {
                    response.Code = true;
                    response.Data = entity;
                }
                else {
                    var result = await _IWebSiteRepository.Query(a => a.SiteId == route.mark)
                                                          .Select(a => new WebSiteValue() {
                                                              SiteId = a.SiteId,
                                                              SiteName = a.SiteName,
                                                              SiteUrls = a.SiteUrls,
                                                              LogoUrls = a.LogoUrls,
                                                              Title = a.Title,
                                                              Keywords = a.Keywords,
                                                              Description = a.Description
                                                          })
                                                          .SingleOrDefaultAsync();
                    if (result != null) {
                        await _IWebSiteRedis.AddAsync(route.mark, result);
                        response.Code = true;
                        response.Data = result;
                    }
                    else
                        return NotFound("数据不存在或未定义！");
                }

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 站点访问信息统计
        /// </summary>
        /// <param name="source"> Source : {"Ip": "127.0.0.1","Device": "ios","DeviceVers": "14.0.23","SystemVers": "1.0.0"} </param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("{mark}/Access")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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