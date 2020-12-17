using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Extend;
using Auto.ElasticServices.Contracts;
using Auto.ElasticServices.Modals;
using Auto.RedisServices.Repositories;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models.Route;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Filters;
using Gbxx.WebApi.Models;
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
    [Route("v1/{mark}/[controller]")]
    public class NewsController : DefaultController {
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
        protected IWebNewsRedis _IWebNewsRedis;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webNewsElastic"></param>
        /// <param name="webNewsRedis"></param>
        public NewsController(ILogger<SiteController> logger,
                              IWebNewsElastic webNewsElastic,
                              IWebNewsRedis webNewsRedis) {
            this._ILogger = logger;
            this._IWebNewsElastic = webNewsElastic;
            this._IWebNewsRedis = webNewsRedis;
        }
        /// <summary>
        /// 新闻信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse(200, "", typeof(NewsResponse))]
        public async Task<IActionResult> GetNewsAsync([FromHeader]String source,
                                                      [FromRoute]SiteIdRoute route) {
            var response = new Response<NewsResponse>();
            try {
                var request = new GetDescriptor<WebNewsDoc>(_IWebNewsElastic.IndexName, route.id);
                // 排除返回字段
                request.SourceExcludes(a => new { a.Img, a.ImagePath, a.DisplayType });
                // 只获取元数据
                var result = await this._IWebNewsElastic.Client
                                                        .GetAsync<NewsResponse>(request);
                if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
                    if (!string.IsNullOrEmpty(result.Source.NewsId)) {
                        response.Code = true;
                        response.Data = result.Source;
                    }
                    else
                        return NotFound();
                }
                else {
                    return NotFound();
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        ///// <summary>
        ///// 新闻首页轮播列表
        ///// </summary>
        ///// <param name="source"></param>
        ///// <param name="route"></param>
        ///// <param name="item"></param>
        ///// <returns></returns>
        //[HttpGet("Carousel")]
        //[SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        //public async Task<IActionResult> GetNewsCarouselAsync([FromHeader]String source,
        //                                                      [FromRoute]SiteRoute route,
        //                                                      [FromQuery]PagerElastic item) {
        //    var response = new Response<List<NewsListResponse>>();
        //    try {
        //        var request = new SearchRequest<WebNewDoc>(_IWebNewsElastic.IndexName) {
        //            TrackTotalHits = true,
        //            Query = new TermQuery() {
        //                Field = "displayType",
        //                Value = "1",
        //            },
        //            Source = new Union<bool, ISourceFilter>(new SourceFilter {
        //                Excludes = new[] { "contents" }
        //            }),
        //            Sort = new List<ISort>() {
        //                new FieldSort (){ Field = "pushTime", Order = SortOrder.Descending },
        //                new FieldSort() { Field = "newsId", Order = SortOrder.Descending }
        //            },
        //            Size = item.PageSize
        //        };
        //        var result = await this._IWebNewsElastic.Client
        //                                                .SearchAsync<NewsListResponse>(request);
        //        if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
        //            if (result.Documents.Count > 0) {
        //                response.Code = true;
        //                response.Data = result.Documents.ToList();
        //            }
        //            else
        //                return NoContent();
        //        }
        //        else {
        //            return NoContent();
        //        }
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }
        //    return response.ToHttpResponse();
        //}
        ///// <summary>
        ///// 新闻首页大标信息
        ///// </summary>
        ///// <param name="source"></param>
        ///// <param name="route"></param>
        ///// <returns></returns>
        //[HttpGet("Big")]
        //[SwaggerResponse(200, "", typeof(NewsListResponse))]
        //public async Task<IActionResult> GetNewsBigAsync([FromHeader]String source,
        //                                                 [FromRoute]SiteRoute route) {
        //    var response = new Response<NewsListResponse>();
        //    try {
        //        var request = new SearchRequest<WebNewDoc>(_IWebNewsElastic.IndexName) {
        //            TrackTotalHits = true,

        //            Query = new BoolQuery() {
        //                Must = new QueryContainer[] {
        //                    new TermQuery() {
        //                        Field = "marks",
        //                        Value = route.mark
        //                    }
        //                    &&  new TermQuery() {
        //                        Field = "displayType",
        //                        Value = "2"
        //                    }
        //                }
        //            },
        //            Source = new Union<bool, ISourceFilter>(new SourceFilter {
        //                Excludes = new[] { "contents" }
        //            }),
        //            Sort = new List<ISort>() {
        //                new FieldSort (){ Field = "pushTime", Order = SortOrder.Descending }
        //            },
        //            Size = 1
        //        };
        //        var result = await this._IWebNewsElastic.Client
        //                                                .SearchAsync<NewsListResponse>(request);

        //        if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
        //            if (result.Documents.SingleOrDefault() != null) {
        //                response.Code = true;
        //                response.Data = result.Documents.SingleOrDefault();
        //            }
        //            return NoContent();
        //        }
        //        else {
        //            return NoContent();
        //        }
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }
        //    return response.ToHttpResponse();
        //}
        /// <summary>
        /// 新闻访问统计
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Access")]
        public async Task<IActionResult> GetNewsAccessAsync([FromHeader]String source,
                                                            [FromRoute]SiteIdRoute route) {
            var response = new Response<Object>();
            try {
                var result = await this._IWebNewsRedis.AddAccessCount(route.mark, route.id);
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
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Click")]
        public async Task<IActionResult> GetNewsClickAsync([FromHeader]String source,
                                                           [FromRoute]SiteIdRoute route) {
            var response = new Response<Object>();
            try {
                var result = await this._IWebNewsRedis.AddClickCount(route.mark, route.id);
                if (!result)
                    return BadRequest("新闻点击统计失败！");
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
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(NewsListResponse))]
        [HttpGet("Tag")]
        public async Task<IActionResult> GetNewsSearchAsync([FromHeader]String source,
                                                            [FromRoute]SiteRoute route,
                                                            [FromQuery]NewsTitleSearchGet item) {
            var response = new Response<Object>();
            try {
                var request = new SearchRequest<WebNewsDoc>(_IWebNewsElastic.IndexName) {
                    TrackTotalHits = true,
                    //Analyzer = "ik_smart",
                    Query = new BoolQuery() {
                        Must = new QueryContainer[] {
                            new TermQuery() {
                                Field = "siteId",
                                Value = route.mark
                            }
                            && new MatchQuery() {
                                Field = "newsTitle",
                                Query = item.Title
                            }
                        },
                        MustNot = new QueryContainer[] {
                             new TermQuery(){
                                Field = "contentType",
                                Value = 2
                            }&&
                            new MatchPhraseQuery(){
                                Field= "newsTitle",
                                Query = item.Title
                            }
                        }
                    },
                    Source = new Union<bool, ISourceFilter>(new SourceFilter {
                        Excludes = new[] { "contents" }
                    }),
                    Sort = new List<ISort>() {
                        new FieldSort (){ Field = "pushTime", Order = SortOrder.Descending }
                    },
                    Highlight = new Highlight() {
                        PreTags = new[] { "<em style='color:#f73131'>" },
                        PostTags = new[] { "</em>" },
                        Fields = new Dictionary<Field, IHighlightField>() { { "newsTitle", new HighlightField { } } }
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
                    if (result.Hits.Count > 0) {
                        response.Code = true;
                        var data = new List<Dictionary<string, Object>>();
                        foreach (var hit in result.Hits) {
                            var entity = new Dictionary<string, Object>();
                            entity.Add("highlight", hit.Highlight.Values.ElementAt(0).First());
                            entity.Add("entity", hit.Source);
                            data.Add(entity);
                        }
                        response.Data = data;
                        response.Other = string.Join(',', result.Hits.LastOrDefault().Sorts);
                    }
                    else {
                        return NoContent();
                    }
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
        /// 新闻标题检索2.0
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(NewsListResponse))]
        [HttpGet("Tags")]
        public async Task<IActionResult> Test([FromHeader]String source,
                                                            [FromRoute]SiteRoute route,
                                                            [FromQuery]NewsTitleSearchGet item) {
            var response = new Response<Object>();
            try {
                var headerSource = source.ToObject<HeaderSource>();
                item.ShowType = item.ShowType == 0 ? 1 : item.ShowType;
                // 针对安卓版本判断
                var lastVers = new Version("1.0.4"); // 最后版本
                var newVers = new Version(headerSource.SystemVers); // 最新版本

                string[] newsSearchAfter = null; // 新闻分页
                string[] videoSearchAfter = null; // 视频分页

                var mustNot = new QueryContainer[] {
                    new MatchPhraseQuery(){
                        Field = "newsTitle",
                        Query = item.Title
                     }
                };
                if (headerSource.Device == "android" && newVers > lastVers) {
                    mustNot = new QueryContainer[] {
                        new TermQuery(){
                            Field = "contentType",
                            Value = 2
                        } &&
                        new MatchPhraseQuery(){
                            Field = "newsTitle",
                            Query = item.Title
                        }
                    };
                }
                // 页
                int? from = null;
                if (!string.IsNullOrEmpty(item.PageIndex)) {
                    from = 0;
                    var after = item.PageIndex.Split("|");
                    if (after.Length > 1) {
                        newsSearchAfter = string.IsNullOrEmpty(after[0]) ? null : after[0].Split(',');
                        videoSearchAfter = string.IsNullOrEmpty(after[1]) ? null : after[1].Split(',');
                    }
                    else {
                        newsSearchAfter = item.PageIndex.Split(",");
                    }
                }
                else {
                    from = null;
                }
                Func<int, Func<SearchDescriptor<NewsListResponse>, ISearchRequest>> searchSelector = (x) => {
                    string[] searchAfter = null;
                    var pageSize = item.PageSize;
                    if (x == 1) {
                        searchAfter = newsSearchAfter;
                    }
                    else if (x == 2) {
                        searchAfter = videoSearchAfter;
                        pageSize = pageSize / 2;
                    }

                    Func<SearchDescriptor<NewsListResponse>, ISearchRequest> func = a => a
                        .Index(_IWebNewsElastic.IndexName)
                        .TrackTotalHits(true)
                        .Query(c => c
                            .Bool(d => d
                                .Must(e => e
                                    .Term("siteId", route.mark) && e
                                    .Term(f => f.ContentType, x) && e
                                    .Match(f => f.Field(g => g.NewsTitle).Query(item.Title))
                                    )
                                .MustNot(mustNot)))
                         .Source(c => c.Excludes(d => d.Field("contents")))
                         .Sort(c => c.Field(d => d.PushTime, SortOrder.Descending))
                         .Highlight(c => c.PreTags("<em style='color:#f73131'>")
                                          .PostTags("</em>")
                                          .Fields(f => f
                                              .Field("newsTitle")
                                          ))
                         .Size(pageSize)
                         .From(from)
                         .SearchAfter(searchAfter);
                    return func;
                };

                MultiSearchResponse result;
                if (item.ShowType == 3) {
                    // 显示文章和视频
                    result = await _IWebNewsElastic.Client.MultiSearchAsync(null, a => a.Search<NewsListResponse>("news", searchSelector(1))
                                                                                        .Search<NewsListResponse>("videos", searchSelector(2)));
                }
                else {
                    result = await _IWebNewsElastic.Client.MultiSearchAsync(null, a => a.Search<NewsListResponse>("news", searchSelector(item.ShowType)));
                }
                if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
                    var news = result.GetResponse<NewsListResponse>("news");
                    var videos = result.GetResponse<NewsListResponse>("videos");
                    if (news.Hits.Count > 0) {
                        response.Code = true;
                        var data = new List<Dictionary<string, Object>>();
                        var entity = new Dictionary<string, Object>();

                        if (item.ShowType == 3) {
                            if (videos.Hits.Count > 0) {
                                var videosHits = videos.Hits.ToList();
                                for (int i = 0; i < news.Hits.Count; i++) {
                                    var newsHit = news.Hits.ElementAt(i);
                                    if (i + 1 >= news.Hits.Count)
                                        break;
                                    else {
                                        entity.Add("highlight", newsHit.Highlight.Values.ElementAt(0).First());
                                        entity.Add("entity", newsHit.Source);
                                        data.Add(entity);

                                        if ((i + 1) % 2 == 0 && i > 0) {
                                            var videosHit = videosHits.FirstOrDefault();
                                            if (videosHit != null) {
                                                entity = new Dictionary<string, object>();
                                                if (videosHits.Count > 0)
                                                    videosHits.Remove(videosHit);
                                                entity.Add("highlight", videosHit.Highlight.Values.ElementAt(0).First());
                                                entity.Add("entity", videosHit.Source);
                                                data.Add(entity);
                                            }
                                        }
                                    }
                                }
                                videosHits.ForEach(x => {
                                    var videosHit = videosHits.FirstOrDefault();
                                    entity = new Dictionary<string, Object>();
                                    entity.Add("highlight", videosHit.Highlight.Values.ElementAt(0).First());
                                    entity.Add("entity", videosHit.Source);
                                    data.Add(entity);
                                });

                                response.Data = data;
                                response.Other = string.Join(',', news.Hits.LastOrDefault().Sorts);
                            }
                            else {
                                foreach (var hit in news.Hits) {
                                    entity = new Dictionary<string, Object>();
                                    entity.Add("highlight", hit.Highlight.Values.ElementAt(0).First());
                                    entity.Add("entity", hit.Source);
                                    data.Add(entity);
                                }
                                response.Data = data;
                                response.Other = string.Join(',', news.Hits.LastOrDefault().Sorts);
                            }
                        }
                        else {
                            foreach (var hit in news.Hits) {
                                entity = new Dictionary<string, Object>();
                                entity.Add("highlight", hit.Highlight.Values.ElementAt(0).First());
                                entity.Add("entity", hit.Source);
                                data.Add(entity);
                            }
                            response.Data = data;
                            response.Other = string.Join(',', news.Hits.LastOrDefault().Sorts);
                        }
                    }
                    else {
                        return NoContent();
                    }
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
        /// 24小时热文
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(NewsListResponse))]
        [HttpGet("Hot")]
        public async Task<IActionResult> GetNewsHotAsync([FromHeader]String source,
                                                         [FromRoute]SiteRoute route,
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
                            && new DateRangeQuery() {
                                Field = "pushTime",
                                GreaterThanOrEqualTo = System.DateTime.Now.ToString("yyyy-MM-dd 00:00:00"),
                                LessThanOrEqualTo = System.DateTime.Now.ToString("yyyy-MM-dd 23:59:59"),
                                Format = "yyyy-MM-dd HH:mm:ss"
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
                        new FieldSort (){ Field = "accessCount", Order = SortOrder.Descending }
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
                    else {
                        return NoContent();
                    }
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
    }
}