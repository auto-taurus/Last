using Auto.Commons.ApiHandles.Responses;
using Auto.ElasticServices.Contracts;
using Auto.RedisServices;
using Gbxx.WebApi.Requests.Query;
using Gbxx.WebApi.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {

    /// <summary>
    /// 
    /// </summary>
    [Route("v1/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TestDataController : ControllerBase {
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
        protected IRedisStore _IRedisStore;
        public TestDataController(
            ILogger<TestDataController> logger,
            //IWebNewsElastic webNewsElastic,
            //IMySqlRepository mySqlRepository, 
            IRedisStore redisStore) {

            this._ILogger = logger;
            //this._IWebNewsElastic = webNewsElastic;
            //this._IMySqlRepository = mySqlRepository;
            //_IWebNewsElastic.AddIndexAsync(_IWebNewsElastic.IndexName);
            this._IRedisStore = redisStore;
        }
        /// <summary>
        /// 站点访问信息统计
        /// </summary>
        /// <param name="args"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("{mark}/Access")]
        public async Task<IActionResult> GetSiteAccessAsync([FromHeader]String source,
                                                            [FromQuery]SiteAccessGet item) {
            var response = new Response<Object>();
            try {

                var dd = this._IRedisStore.Instance;
                //List<NewsDoc> result;
                //for (int pageIndex = 1; pageIndex <= 60; pageIndex++) {
                //    result = new List<NewsDoc>();
                //    result = _IMySqlRepository.GetList(pageIndex, 50000, 1910325);
                //    await _IWebNewsElastic.BatchAddDocumentAsync(_IWebNewsElastic.IndexName, result);
                //}
                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}