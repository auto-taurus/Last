using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.ElasticDoc;
using Gbxx.WebApi.Requests;
using Gbxx.WebApi.Requests.Query;
using Gbxx.WebApi.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nest;
using Swashbuckle.AspNetCore.Annotations;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    /// <summary>
    /// 新闻管理
    /// </summary>
    public class NewsController : DefaultController {
        protected readonly ILogger _ILogger;
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
        /// <param name="mark"></param>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse(200, "", typeof(NewsDto))]
        public async Task<IActionResult> GetNewsAsync(string mark, string id, [FromQuery]RequestBase args) {
            var response = new Response<NewsDto>();
            try {
                var request = new GetDescriptor<NewsDoc>("gbxx-news", id);
                request.SourceExcludes(a => new { a.Img, a.ImagePath, a.DisplayType });
                var result = await this._client.SourceAsync<NewsDto>(id, a => a.Index("gbxx-news"));
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
        /// <param name="mark"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet("Carousel")]
        [SwaggerResponse(200, "", typeof(List<NewsListDto>))]
        public async Task<IActionResult> GetNewsCarouselAsync(string mark, [FromQuery]QueryPager args) {
            var response = new Response<List<NewsListDto>>();
            try {
                var request = new SearchRequest<NewsDoc>("gbxx-news") {
                    TrackTotalHits = true,
                    Query = new MatchQuery() {
                        Query = "1",
                        Field = "displayType"
                    },
                    Source = new Union<bool, ISourceFilter>(new SourceFilter {
                        Excludes = new[] { "contents" }
                    }),
                    Sort = new List<ISort>() {
                        new FieldSort (){ Field = "pushTime", Order = SortOrder.Descending },
                        new FieldSort() { Field = "newsId", Order = SortOrder.Descending }
                    },
                    Size = args.PageSize
                };
                ISearchResponse<NewsListDto> result;
                result = await this._client.SearchAsync<NewsListDto>(request);
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
        [SwaggerResponse(200, "", typeof(NewsListDto))]
        public async Task<IActionResult> GetNewsBigAsync(string mark, [FromQuery]RequestBase args) {
            var response = new Response<NewsListDto>();
            try {
                var request = new SearchRequest<NewsDoc>("gbxx-news") {
                    TrackTotalHits = true,
                    Query = new MatchQuery() {
                        Query = "2",
                        Field = "displayType"
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
                ISearchResponse<NewsListDto> result;
                result = await this._client.SearchAsync<NewsListDto>(request);

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
        /// <param name="mark">站点标识</param>
        /// <param name="id">文章编号</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet("{id}/Access")]
        public async Task<IActionResult> GetNewsAccessAsync(string mark, string id, [FromQuery]RequestBase args) {
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
        /// <param name="mark">站点标识</param>
        /// <param name="id">文章编号</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet("{id}/Click")]
        public async Task<IActionResult> GetNewsClickAsync(string mark, string id, [FromQuery]RequestBase args) {
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
        /// <param name="mark">站点标识</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListDto>))]
        [HttpGet("Tag")]
        public async Task<IActionResult> GetNewsSearchAsync(string mark, [FromQuery]NewsSearchQuery args) {
            var response = new Response<Object>();
            try {
                var request = new SearchRequest<NewsDoc>("gbxx-news") {
                    TrackTotalHits = true,
                    Query = new MatchQuery() {
                        Query = args.Title,
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
                    Size = args.PageSize
                };
                ISearchResponse<NewsListDto> result;
                if (args.PageIndex != null) {
                    request.From = 0;
                    request.SearchAfter = args.PageIndex;
                }
                result = await this._client.SearchAsync<NewsListDto>(request);
                if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
                    response.Code = true;
                    var data = new List<Dictionary<string, Object>>();
                    foreach (var item in result.Hits) {
                        var entity = new Dictionary<string, Object>();
                        entity.Add("highlight", item.Highlight);
                        entity.Add("entities", item.Source);
                        data.Add(entity);
                    }
                    response.Data = data;
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
        /// 文章热门访问
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListDto>))]
        [HttpGet("Hot")]
        public async Task<IActionResult> GetNewsHotAsync(string mark, [FromQuery]QueryPager args) {
            var response = new Response<List<NewsListDto>>();
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
                    Size = args.PageSize
                };
                ISearchResponse<NewsListDto> result;
                if (args.PageIndex != null) {
                    request.From = 0;
                    request.SearchAfter = args.PageIndex;
                }
                result = await this._client.SearchAsync<NewsListDto>(request);
                if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
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
    }
}