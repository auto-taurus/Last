using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.ElasticDoc;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models;
using Gbxx.WebApi.Requests.Query;
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
    /// 新闻管理
    /// </summary>
    public class NewsController : DefaultController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IElasticClient _client;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="elasticClient"></param>
        public NewsController(ILogger<SiteController> logger,
            IElasticClient elasticClient) {
            this._ILogger = logger;
            this._client = elasticClient;
        }
        /// <summary>
        /// 新闻信息
        /// </summary>
        /// <param name="args"></param>
        /// <param name="mark"></param>
        /// <param name="id">新闻编号</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse(200, "", typeof(NewsResponse))]
        public async Task<IActionResult> GetNewsAsync([FromHeader(Name = "Device-Args")]string args,
                                                      string mark,
                                                      string id) {
            var response = new Response<NewsResponse>();
            try {
                var request = new GetDescriptor<NewsDoc>("gbxx-news", id);
                request.SourceExcludes(a => new { a.Img, a.ImagePath, a.DisplayType });
                var result = await this._client.SourceAsync<NewsResponse>(id, a => a.Index("gbxx-news"));
                if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
                    response.Code = true;
                    response.Data = result.Body;
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
        /// 新闻首页轮播列表
        /// </summary>
        /// <param name="args"></param>
        /// <param name="mark"></param>
        /// <param name="item">分页信息</param>
        /// <returns></returns>
        [HttpGet("Carousel")]
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        public async Task<IActionResult> GetNewsCarouselAsync([FromHeader(Name = "Device-Args")]string args,
                                                              string mark,
                                                              [FromQuery]PageItem item) {
            var response = new Response<List<NewsListResponse>>();
            try {
                var request = new SearchRequest<NewsDoc>("gbxx-news") {
                    TrackTotalHits = true,
                    Query = new TermQuery() {
                        Field = "displayType",
                        Value = "1",
                    },
                    Source = new Union<bool, ISourceFilter>(new SourceFilter {
                        Excludes = new[] { "contents" }
                    }),
                    Sort = new List<ISort>() {
                        new FieldSort (){ Field = "pushTime", Order = SortOrder.Descending },
                        new FieldSort() { Field = "newsId", Order = SortOrder.Descending }
                    },
                    Size = item.PageSize
                };
                ISearchResponse<NewsListResponse> result;
                result = await this._client.SearchAsync<NewsListResponse>(request);
                if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
                    response.Code = true;
                    response.Data = result.Documents.ToList();
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
        /// 新闻首页大标信息
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet("Big")]
        [SwaggerResponse(200, "", typeof(NewsListResponse))]
        public async Task<IActionResult> GetNewsBigAsync([FromHeader(Name = "Device-Args")]string args,
                                                         string mark) {
            var response = new Response<NewsListResponse>();
            try {
                var request = new SearchRequest<NewsDoc>("gbxx-news") {
                    TrackTotalHits = true,
                    Query = new TermQuery() {
                        Field = "displayType",
                        Value = "2"
                    },
                    Source = new Union<bool, ISourceFilter>(new SourceFilter {
                        Excludes = new[] { "contents" }
                    }),
                    Sort = new List<ISort>() {
                        new FieldSort (){ Field = "pushTime", Order = SortOrder.Descending },
                        new FieldSort() { Field ="newsId", Order = SortOrder.Descending }
                    },
                    Size = 1
                };
                ISearchResponse<NewsListResponse> result;
                result = await this._client.SearchAsync<NewsListResponse>(request);

                if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
                    response.Code = true;
                    response.Data = result.Documents.SingleOrDefault();
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
        /// 新闻访问统计
        /// </summary>
        /// <param name="args"></param>
        /// <param name="mark"></param>
        /// <param name="id">新闻编号</param>
        /// <returns></returns>
        [HttpGet("{id}/Access")]
        public async Task<IActionResult> GetNewsAccessAsync([FromHeader(Name = "Device-Args")]string args,
                                                            string mark,
                                                            string id) {
            var response = new Response<Object>();
            try {
                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }

        /// <summary>
        /// 新闻点击统计
        /// </summary>
        /// <param name="args"></param>
        /// <param name="mark"></param>
        /// <param name="id">新闻编号</param>
        /// <returns></returns>
        [HttpGet("{id}/Click")]
        public async Task<IActionResult> GetNewsClickAsync([FromHeader(Name = "Device-Args")]string args,
                                                           string mark,
                                                           string id) {
            var response = new Response<Object>();
            try {
                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 新闻标题检索
        /// </summary>
        /// <param name="args"></param>
        /// <param name="mark"></param>
        /// <param name="item">标题查询分页</param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        [HttpGet("Tag")]
        public async Task<IActionResult> GetNewsSearchAsync([FromHeader(Name = "Device-Args")]string args,
                                                            string mark,
                                                            [FromQuery]NewsTitleSearchGet item) {
            var response = new Response<Object>();
            try {
                var request = new SearchRequest<NewsDoc>("gbxx-news") {
                    TrackTotalHits = true,
                    Query = new MatchQuery() {
                        Query = item.Title,
                        Field = "newsTitle"
                    },
                    Source = new Union<bool, ISourceFilter>(new SourceFilter {
                        Excludes = new[] { "contents" }
                    }),
                    Sort = new List<ISort>() {
                        new FieldSort (){ Field = "pushTime", Order = SortOrder.Descending },
                        new FieldSort() { Field ="newsId", Order = SortOrder.Descending }
                    },
                    Highlight = new Highlight() {
                        PreTags = new[] { "<br>" },
                        PostTags = new[] { "</br>" },
                        Fields = new Dictionary<Field, IHighlightField>() { { "newsTitle", new HighlightField { } } }
                    },
                    Size = item.PageSize
                };
                ISearchResponse<NewsListResponse> result;
                if (item.PageIndex != null) {
                    request.From = 0;
                    request.SearchAfter = item.PageIndex.Split(",");
                }
                result = await this._client.SearchAsync<NewsListResponse>(request);
                if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
                    response.Code = true;
                    var data = new List<Dictionary<string, Object>>();
                    foreach (var hit in result.Hits) {
                        var entity = new Dictionary<string, Object>();
                        entity.Add("highlight", hit.Highlight);
                        entity.Add("entities", hit.Source);
                        data.Add(entity);
                    }
                    response.Data = data;
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
        /// 文章热门访问
        /// </summary>
        /// <param name="args"></param>
        /// <param name="mark"></param>
        /// <param name="item">分页信息</param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        [HttpGet("Hot")]
        public async Task<IActionResult> GetNewsHotAsync([FromHeader(Name = "Device-Args")]string args,
                                                         string mark,
                                                         [FromQuery]PageItem item) {
            var response = new Response<List<NewsListResponse>>();
            try {
                var request = new SearchRequest<NewsDoc>("gbxx-news") {
                    TrackTotalHits = true,
                    Source = new Union<bool, ISourceFilter>(new SourceFilter {
                        Excludes = new[] { "contents" }
                    }),
                    Sort = new List<ISort>() {
                        new FieldSort (){ Field = "accessCount", Order = SortOrder.Descending },
                        new FieldSort() { Field = "newsId", Order = SortOrder.Descending }
                    },
                    Size = item.PageSize
                };
                ISearchResponse<NewsListResponse> result;
                if (item.PageIndex != null) {
                    request.From = 0;
                    request.SearchAfter = args.Split(",");
                }
                result = await this._client.SearchAsync<NewsListResponse>(request);
                if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
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
    }
}