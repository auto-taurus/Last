using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Extend;
using Auto.DataServices.Contracts;
using Auto.ElasticServices.Contracts;
using Auto.ElasticServices.Modals;
using Auto.RedisServices.Modals;
using Auto.RedisServices.Repositories;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models.Route;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    [Route("v1/{mark}/[controller]")]
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
        protected IWebCategoryRepository _IWebCategoryRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webNewsElastic"></param>
        /// <param name="webCategoryRedis"></param>
        /// <param name="webCategoryRepository"></param>
        public CategoryController(
                              ILogger<SiteController> logger,
                              IWebNewsElastic webNewsElastic,
                              IWebCategoryRedis webCategoryRedis,
            IWebCategoryRepository webCategoryRepository) {
            this._ILogger = logger;
            this._IWebNewsElastic = webNewsElastic;
            this._IWebCategoryRedis = webCategoryRedis;
            this._IWebCategoryRepository = webCategoryRepository;
        }

        /// <summary>
        /// 分类信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse(200, "", typeof(WebCategoryValue))]
        public async Task<IActionResult> GetCategoryAsync([FromHeader]String source,
                                                          [FromRoute]SiteIdRoute route) {
            var response = new Response<object>();
            var categoryId = route.id.ToInt();//分类Id
            try {
                var result = await this._IWebCategoryRedis.GetAsync(route.mark);
                if (result.Count > 0) {
                    var newResult = result.FirstOrDefault(c => c.CategoryId == categoryId);//根据分类标识获取分类信息
                    response.Code = true;
                    response.Data = newResult;
                    response.Message = newResult == null ? "未找到相关数据！" : "Success";
                }
                else {
                    var entities = await _IWebCategoryRepository.Query(a => a.SiteId == route.mark && a.IsEnable == 1,
                                                                       a => a.Sequence)
                                                                 .Select(a => new WebCategoryValue() {
                                                                     CategoryId = a.CategoryId,
                                                                     ChannelId = Convert.ToInt32(a.Remarks),
                                                                     CategoryName = a.CategoryName,
                                                                     ParentId = a.ParentId,
                                                                     Controller = a.Controller,
                                                                     Action = a.Action,
                                                                     Urls = a.Urls,
                                                                     Title = a.Title,
                                                                     Keywords = a.Keywords,
                                                                     Description = a.Description
                                                                 })
                                                                 .ToListAsync();

                    if (entities.Count > 0) {
                        await _IWebCategoryRedis.AddAsync(route.mark, entities);
                        response.Code = true;
                        response.Data = entities.FirstOrDefault(c => c.CategoryId == categoryId);//根据分类标识获取分类信息
                    }
                    else
                        return NoContent();
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }


        /// <summary>
        /// 分类列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(WebCategoryValue))]
        [HttpGet]
        public async Task<IActionResult> GetCategoriesAsync([FromHeader]String source,
                                                            [FromRoute]SiteRoute route) {
            var response = new Response<List<WebCategoryValue>>();
            try {
                var result = await this._IWebCategoryRedis.GetAsync(route.mark);
                if (result.Count > 0) {
                    response.Code = true;
                    response.Data = result;
                }
                else {
                    var entities = await _IWebCategoryRepository.Query(a => a.SiteId == route.mark && a.IsEnable == 1,
                                                                       a => a.Sequence)
                                                                 .Select(a => new WebCategoryValue() {
                                                                     CategoryId = a.CategoryId,
                                                                     ChannelId = Convert.ToInt32(a.Remarks),
                                                                     CategoryName = a.CategoryName,
                                                                     ParentId = a.ParentId,
                                                                     Controller = a.Controller,
                                                                     Action = a.Action,
                                                                     Urls = a.Urls,
                                                                     Title = a.Title,
                                                                     Keywords = a.Keywords,
                                                                     Description = a.Description
                                                                 })
                                                                 .ToListAsync();
                    if (entities.Count > 0) {
                        await _IWebCategoryRedis.AddAsync(route.mark, entities);
                        response.Code = true;
                        response.Data = entities;
                    }
                    else
                        return NoContent();
                }
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
        [SwaggerResponse(200, "", typeof(NewsListResponse))]
        [HttpGet("{id}/News")]

        public async Task<IActionResult> GetCategoryNewsAsync([FromHeader]String source,
                                                              [FromRoute]SiteIdRoute route,
                                                              [FromQuery]PagerElastic item) {
            var response = new Response<List<NewsListResponse>>();
            try {
                var request = new SearchRequest<WebNewsDoc>(_IWebNewsElastic.IndexName) {
                    TrackTotalHits = true,
                    Query = new BoolQuery() {
                        Must = new QueryContainer[] {
                            new TermQuery() {
                                Field = "siteId",
                                Value = route.mark
                            }
                            && new TermQuery() {
                                Field = "categoryId",
                                Value = route.id
                            }
                        },
                        MustNot = new QueryContainer[] {
                            new TermQuery(){
                                Field = "contentType",
                                Value = 2
                            }
                        }
                    },
                    Source = new Union<bool, ISourceFilter>(new SourceFilter {
                        Excludes = new[] { "contents" }
                    }),
                    Sort = new List<ISort>() {
                        new FieldSort (){ Field = "categorySort", Order = SortOrder.Ascending },
                        new FieldSort() { Field ="pushTime", Order = SortOrder.Descending }
                    },
                    Size = item.PageSize
                };
                if (item.PageIndex != null) {
                    request.From = 0;
                    request.SearchAfter = item.PageIndex.Split(",");
                }
                var result = await this._IWebNewsElastic.Client
                                                        .SearchAsync<NewsListResponse>(request);
                if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
                    if (result.Documents.Count > 0) {
                        response.Code = true;
                        response.Data = result.Documents.ToList();
                        response.Other = string.Join(',', result.Hits.LastOrDefault().Sorts);
                    }
                    else
                        return NoContent();
                }
                else {
                    return NoContent();
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
                    return BadRequest("分类点击统计失败！");
                response.Code = result;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}