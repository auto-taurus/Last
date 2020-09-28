using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.ElasticDoc;
using Auto.ElasticServices.Contracts;
using Gbxx.WebApi.Requests;
using Gbxx.WebApi.Requests.Query;
using Gbxx.WebApi.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
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
        protected IMySqlRepository _IMySqlRepository;
        protected IWebNewsElastic _IWebNewsElastic;
        /// <summary>
        /// 站点管理
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webNewsElastic"></param>
        public SiteController(
            ILogger<SiteController> logger,
            IWebNewsElastic webNewsElastic,
            IMySqlRepository mySqlRepository) {
            this._ILogger = logger;
            this._IWebNewsElastic = webNewsElastic;
            this._IMySqlRepository = mySqlRepository;
            _IWebNewsElastic.AddIndexAsync(_IWebNewsElastic.IndexName);
        }
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="mark">站点标记</param>
        /// <param name="args">查询字段</param>
        /// <returns></returns>
        [HttpGet("{mark}")]
        [SwaggerResponse(200, "", typeof(Responses.SiteDto))]
        public async Task<IActionResult> GetWebSiteAsync(string mark, [FromQuery]RequestBase args) {
            var response = new Response<Responses.SiteDto>();
            try {
                var entityWebSite = new Responses.SiteDto();

                response.Code = true;
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
        /// <param name="args">基础参数</param>
        /// <returns></returns>
        [HttpGet("{mark}/Access")]
        public async Task<IActionResult> GetSiteAccessAsync(string mark, [FromQuery]SiteAccessQuery args) {
            var response = new Response<Object>();
            try {
                List<NewsDoc> result;
                for (int pageIndex = 1; pageIndex <= 60; pageIndex++) {
                    result = new List<NewsDoc>();
                    result = _IMySqlRepository.GetList(pageIndex, 50000, 1910325);
                    await _IWebNewsElastic.BatchAddDocumentAsync(_IWebNewsElastic.IndexName, result);
                }
                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}