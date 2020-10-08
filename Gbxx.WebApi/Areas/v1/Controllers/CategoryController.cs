using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.ElasticDoc;
using Auto.Dto.RedisDto;
using Auto.ElasticServices.Contracts;
using Auto.RedisServices.Repositories;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models;
using Gbxx.WebApi.Areas.v1.Models.Route;
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
        protected IWebCategoryRedis _IWebCategoryRedis;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webNewsElastic"></param>
        /// <param name="elasticClient"></param>
        /// <param name="webCategoryRedis"></param>
        public CategoryController(
                              ILogger<SiteController> logger,
                              IWebNewsElastic webNewsElastic,
                              IWebCategoryRedis webCategoryRedis) {
            this._ILogger = logger;
            this._IWebNewsElastic = webNewsElastic;
            this._IWebCategoryRedis = webCategoryRedis;
        }
        /// <summary>
        /// 分类列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<CategoryDto>))]
        [HttpGet]
        public async Task<IActionResult> GetCategoriesAsync([FromHeader]String source,
                                                            [FromRoute]SiteRoute route) {
            var response = new Response<List<CategoryDto>>();
            try {
                var result = await this._IWebCategoryRedis.GetAsync(route.mark);
                if (result.Count > 0) {
                    response.Code = true;
                    response.Data = result;
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
        /// 分类新闻列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        [HttpGet("{id}/News")]
        public async Task<IActionResult> GetCategoryNewsAsync([FromHeader]String source,
                                                              [FromRoute]SiteIdRoute route,
                                                              [FromQuery]ElasticPage item) {
            var response = new Response<List<NewsListResponse>>();
            try {
                var request = new SearchRequest<NewsDoc>(_IWebNewsElastic.IndexName) {
                    TrackTotalHits = true,
                    Query = new TermQuery() {
                        Field = "categoryId",
                        Value = route.id
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
                if (item.PageIndex != null) {
                    request.From = 0;
                    request.SearchAfter = item.PageIndex.Split(",");
                }
                var result = await this._IWebNewsElastic.Client
                                                        .SearchAsync<NewsListResponse>(request);
                if (result.ApiCall.Success || result.ApiCall.HttpStatusCode == 200) {
                    if (result.Documents.Count > 0) {
                        response.Code = true;
                        response.Data = result.Documents.ToList();
                        response.Other = string.Join(',', result.Hits.LastOrDefault().Sorts);
                    }
                    else
                        response.Message = "数据不存在！";
                }
                else {
                    response.Message = "获取数据失败！";
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
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Access")]
        public async Task<IActionResult> GetCategoryAccessAsync([FromHeader]String source,
                                                                [FromRoute]SiteIdRoute route) {
            var response = new Response<Object>();
            try {
                await this._IWebCategoryRedis.AddAccessCount(route.mark, route.id);
                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 分类点击统计
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Click")]
        public async Task<IActionResult> GetCategoryClickAsync([FromHeader]String source,
                                                               [FromRoute]SiteIdRoute route) {
            var response = new Response<Object>();
            try {
                var result = await this._IWebCategoryRedis.AddClickCount(route.mark, route.id);
                if (!result)
                    response.Message = "分类点击统计失败！";
                response.Code = result;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}