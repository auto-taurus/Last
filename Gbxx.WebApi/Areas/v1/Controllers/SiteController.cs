using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.ElasticDoc;
using Auto.ElasticServices.Contracts;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models;
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
        /// <summary>
        /// 
        /// </summary>
        protected IMySqlRepository _IMySqlRepository;
        /// <summary>
        /// 
        /// </summary>
        protected IWebNewsElastic _IWebNewsElastic;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webNewsElastic"></param>
        /// <param name="mySqlRepository"></param>
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
        /// <param name="args"></param>
        /// <param name="mark"></param>
        /// <returns></returns>
        [HttpGet("{mark}")]
        [SwaggerResponse(200, "", typeof(SiteResponse))]
        public async Task<IActionResult> GetWebSiteAsync([FromHeader(Name = "Device-Args")]string args,
                                                         string mark) {
            var response = new Response<SiteResponse>();
            try {
                var entityWebSite = new SiteResponse();

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
        /// <param name="args"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("{mark}/Access")]
        public async Task<IActionResult> GetSiteAccessAsync([FromHeader(Name = "Device-Args")]string args,
                                                            [FromQuery]SiteAccessGet item) {
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