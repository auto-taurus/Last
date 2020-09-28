using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.ElasticDoc;
using Auto.ElasticServices.Contracts;
using Elasticsearch.Net;
using Gbxx.WebApi.Requests;
using Gbxx.WebApi.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nest;
using Swashbuckle.AspNetCore.Annotations;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    /// <summary>
    /// 分类管理
    /// </summary>
    public class CategoryController : DefaultController {
        protected readonly ILogger _ILogger;
        protected IWebNewsElastic _IWebNewsElastic;
        protected IElasticClient _client;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
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
        /// <param name="mark">站点标识</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<CategoryDto>))]
        [HttpGet]
        public async Task<IActionResult> GetCategoriesAsync(string mark, [FromQuery]QueryBase args) {
            var response = new Response<List<CategoryDto>>();
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
        /// <param name="mark">站点标识</param>
        /// <param name="id">分类编号</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(CategoryDto))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryAsync(string mark, string id, [FromQuery]QueryBase args) {
            var response = new Response<CategoryDto>();
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
        /// <param name="mark">站点标识</param>
        /// <param name="id">分类编号</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListDto>))]
        [HttpGet("{id}/News")]
        public async Task<IActionResult> GetCategoryNewsAsync(string mark, string id, [FromQuery]QueryPager args) {
            var response = new Response<List<NewsListDto>>();
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
                    Size = args.PageSize
                };
                ISearchResponse<NewsListDto> result;
                if (args.PageIndex != null) {
                    request.From = 0;
                    request.SearchAfter = args.PageIndex;
                }
                result = await this._client.SearchAsync<NewsListDto>(request);
                if (result.ApiCall.Success || result.ApiCall.HttpStatusCode == 200) {
                    response.Code = true;
                    response.Data = result.Documents.ToList();
                    response.Other = result.Hits.LastOrDefault().Sorts;
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
        /// <param name="mark">站点标识</param>
        /// <param name="id">分类编号</param>
        /// <returns></returns>
        [HttpGet("{id}/Access")]
        public async Task<IActionResult> GetCategoryAccessAsync(string mark, string id) {
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
        /// <param name="mark">站点标识</param>
        /// <param name="id">分类编号</param>
        /// <returns></returns>
        [HttpGet("{id}/Click")]
        public async Task<IActionResult> GetCategoryClickAsync(string mark, string id) {
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