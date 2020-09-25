using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.ElasticDoc;
using Auto.Dto.RedisDto;
using Auto.ElasticServices.Contracts;
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
        protected IWebNewsElastic _IWebNewsElastic;
        /// <summary>
        /// 站点管理
        /// </summary>
        /// <param name="logger"></param>
        public SiteController(
            ILogger<SiteController> logger,
            IWebNewsElastic webNewsElastic) {
            this._ILogger = logger;
            this._IWebNewsElastic = webNewsElastic;
        }
        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="args">基础参数</param>
        /// <returns></returns>
        [HttpGet("{mark}")]
        [SwaggerResponse(200, "", typeof(SiteResponse))]
        public async Task<IActionResult> GetWebSiteAsync(string mark, [FromQuery]QueryBase args) {
            var response = new Response<SiteResponse>();
            try {
                var entityWebSite = new SiteResponse();
                //await _IWebNewsElastic.DeleteIndexAsync("newstest");
                await _IWebNewsElastic.CreateIndexAsync("newstest");

                _IWebNewsElastic.SearchAsync("newstest", e =>e);
                var docs = new NewsDoc();
                docs.NewsId = 1;
                docs.CategoryId = 2;
                docs.CategoryName = "社会";
                docs.NewsTitle = "高校外卖堆积外卖员称月入两三万";
                docs.Source = "今日头条";
                docs.Tags = "你好";
                docs.Contents = "";
                docs.Curl = "";
                docs.Img = "";
                docs.ImagePath = "";
                docs.IsHot = 1;
                docs.AccessCount = 2560;
                docs.PushTime = System.DateTime.Now;
                docs.Title = "标题测试";
                docs.Keywords = "关键字测试";
                docs.Description = "描述测试";
                await _IWebNewsElastic.InsertDocumentAsync("newstest", "1", docs, "1");

                var docs1 = new NewsDoc();
                docs1.NewsId = 2;
                docs1.CategoryId = 1;
                docs1.CategoryName = "启航";
                docs1.NewsTitle = "10月工资可以提前至9月发";
                docs1.Source = "今日头条";
                docs1.Tags = "你好";
                docs1.Contents = "";
                docs1.Curl = "";
                docs1.Img = "";
                docs1.ImagePath = "";
                docs1.IsHot = 1;
                docs1.AccessCount = 2560;
                docs1.PushTime = System.DateTime.Now;
                docs1.Title = "标题测试";
                docs1.Keywords = "关键字测试";
                docs1.Description = "描述测试";

                await _IWebNewsElastic.InsertDocumentAsync("newstest", "2", docs1, "2");

                entityWebSite.SiteId = 1;
                response.Data = entityWebSite;
                response.Code = true;
                await Task.Run(() => entityWebSite = new SiteResponse());
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
                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}