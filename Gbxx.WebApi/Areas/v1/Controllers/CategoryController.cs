using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.ElasticDoc;
using Auto.ElasticServices.Contracts;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nest;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    /// <summary>
    /// 分类管理
    /// </summary>
    public class CategoryController : DefaultController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IWebNewsElastic _IWebNewsElastic;
        /// <summary>
        /// 
        /// </summary>
        protected IElasticClient _client;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webNewsElastic"></param>
        /// <param name="elasticClient"></param>
        public CategoryController(
            ILogger<SiteController> logger,
            IWebNewsElastic webNewsElastic,
            IElasticClient elasticClient) {
            this._ILogger = logger;
            this._IWebNewsElastic = webNewsElastic;
            this._client = elasticClient;
        }
        /// <summary>
        /// 分类列表
        /// </summary>
        /// <param name="args">设备信息</param>
        /// <param name="mark">站点标识</param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<CategoryResponse>))]
        [HttpGet]
        public async Task<IActionResult> GetCategoriesAsync([FromHeader(Name = "Device-Args")]String args,
                                                            string mark) {
            var response = new Response<List<CategoryResponse>>();
            try {

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 分类信息
        /// </summary>
        /// <param name="args">设备信息</param>
        /// <param name="mark">站点标识</param>
        /// <param name="id">分类编号</param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(CategoryResponse))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryAsync([FromHeader(Name = "Device-Args")]String args,
                                                          string mark,
                                                          string id) {
            var response = new Response<CategoryResponse>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 分类新闻列表
        /// </summary>
        /// <param name="args">设备信息</param>
        /// <param name="mark">站点标识</param>
        /// <param name="id">分类编号</param>
        /// <param name="item">分页信息</param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        [HttpGet("{id}/News")]
        public async Task<IActionResult> GetCategoryNewsAsync([FromHeader(Name = "Device-Args")]String args,
                                                              string mark,
                                                              string id,
                                                              [FromQuery]PageItem item) {
            var response = new Response<List<NewsListResponse>>();
            try {
                if (string.IsNullOrEmpty(mark.Trim()))
                    return BadRequest("请传递站点标识！");
                if (string.IsNullOrEmpty(id.Trim()))
                    return BadRequest("请传递新闻编号！");

                var request = new SearchRequest<NewsDoc>(_IWebNewsElastic.IndexName) {
                    TrackTotalHits = true,
                    Query = new TermQuery() {
                        Field = "categoryId",
                        Value = id
                    },
                    Source = new Union<bool, ISourceFilter>(new SourceFilter {
                        Excludes = new[] { "contents" }
                    }),
                    Sort = new List<ISort>() {
                        new FieldSort (){ Field = "pushTime", Order = SortOrder.Descending },
                        new FieldSort() { Field ="newsId", Order = SortOrder.Descending }
                    },
                    Size = item.PageSize
                };
                ISearchResponse<NewsListResponse> result;
                if (item.PageIndex != null) {
                    request.From = 0;
                    request.SearchAfter = item.PageIndex.Split(",");
                }
                result = await this._client.SearchAsync<NewsListResponse>(request);
                if (result.ApiCall.Success || result.ApiCall.HttpStatusCode == 200) {
                    response.Code = true;
                    response.Data = result.Documents.ToList();
                    response.Other = string.Join(',', result.Hits.LastOrDefault().Sorts);
                }
                else {
                    response.Message = "获取数据错误！";
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 分类访问统计
        /// </summary>
        /// <param name="args">设备信息</param>
        /// <param name="mark">站点标识</param>
        /// <param name="id">分类编号</param>
        /// <returns></returns>
        [HttpGet("{id}/Access")]
        public async Task<IActionResult> GetCategoryAccessAsync([FromHeader(Name = "Device-Args")]String args,
                                                                string mark,
                                                                string id) {
            var response = new Response<Object>();
            try {

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 分类点击统计
        /// </summary>
        /// <param name="args">设备信息</param>
        /// <param name="mark">站点标识</param>
        /// <param name="id">分类编号</param>
        /// <returns></returns>
        [HttpGet("{id}/Click")]
        public async Task<IActionResult> GetCategoryClickAsync([FromHeader(Name = "Device-Args")]String args,
                                                               string mark,
                                                               string id) {
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