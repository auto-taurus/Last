using Auto.Commons.ApiHandles.Responses;
using Auto.Dto.ElasticDoc;
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
    /// 专栏管理
    /// </summary>
    public class CodeController : DefaultController {
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
        public CodeController(ILogger<SiteController> logger,
                              IElasticClient elasticClient) {
            this._ILogger = logger;
            this._client = elasticClient;
        }
        /// <summary>
        /// 专栏新闻列表
        /// </summary>
        /// <param name="args">设备信息</param>
        /// <param name="mark">站点标识</param>
        /// <param name="code">专栏代码</param>
        /// <param name="item">分页信息</param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        [HttpGet("{code}/News")]
        public async Task<IActionResult> GetCodeNewsAsync([FromHeader(Name = "Device-Args")]string args,
                                                          string mark,
                                                          string code,
                                                          [FromQuery]PageItem item) {
            var response = new Response<List<NewsListResponse>>();
            try {
                if (string.IsNullOrEmpty(mark.Trim()))
                    return BadRequest("请传递站点标识！");
                if (string.IsNullOrEmpty(code.Trim()))
                    return BadRequest("请传递专栏代码！");

                var request = new SearchRequest<NewsDoc>("gbxx-news") {
                    TrackTotalHits = true,
                    Query = new TermQuery() {
                        Field = "code",
                        Value = code
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
    }
}