using Auto.CacheEntities.ElasticDoc;
using Auto.Commons.ApiHandles.Responses;
using Auto.ElasticServices.Contracts;
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
    /// 专栏管理
    /// </summary>
    [Route("v1/{mark}/[controller]")]
    public class CodeController : DefaultController {
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
        /// <param name="logger"></param>
        /// <param name="webNewsElastic"></param>
        public CodeController(ILogger<SiteController> logger,
                              IWebNewsElastic webNewsElastic) {
            this._ILogger = logger;
            this._IWebNewsElastic = webNewsElastic;
        }
        /// <summary>
        /// 专栏新闻列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        [HttpGet("{id}/News")]
        public async Task<IActionResult> GetCodeNewsAsync([FromHeader]String source,
                                                          [FromRoute]SiteIdRoute route,
                                                          [FromQuery]ElasticPage item) {
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
                                Field = "specialCode",
                                Value = route.id
                            }
                        }
                    },
                    Source = new Union<bool, ISourceFilter>(new SourceFilter {
                        Excludes = new[] { "contents" }
                    }),
                    Sort = new List<ISort>() {
                        new FieldSort (){ Field = "specialSort", Order = SortOrder.Ascending },
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