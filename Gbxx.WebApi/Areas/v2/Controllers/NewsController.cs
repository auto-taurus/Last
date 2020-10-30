using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Auto.ElasticServices.Contracts;
using Auto.ElasticServices.Modals;
using Auto.RedisServices.Repositories;
using Gbxx.WebApi.Areas.v1.Controllers;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models.Route;
using Gbxx.WebApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nest;
using Swashbuckle.AspNetCore.Annotations;

namespace Gbxx.WebApi.Areas.v2.Controllers {
    [Route("v2/[controller]")]
    public class NewsController : AuthorizeController {

        ///// <summary>
        ///// 
        ///// </summary>
        //protected readonly ILogger _ILogger;
        ///// <summary>
        ///// 
        ///// </summary>
        //protected IWebNewsElastic _IWebNewsElastic;
        ///// <summary>
        ///// 
        ///// </summary>
        //protected IWebNewsRedis _IWebNewsRedis;
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="logger"></param>
        ///// <param name="webNewsElastic"></param>
        ///// <param name="webNewsRedis"></param>
        //public NewsController(ILogger<SiteController> logger,
        //                      IWebNewsElastic webNewsElastic,
        //                      IWebNewsRedis webNewsRedis) {
        //    this._ILogger = logger;
        //    this._IWebNewsElastic = webNewsElastic;
        //    this._IWebNewsRedis = webNewsRedis;
        //}
        ///// <summary>
        ///// 新闻信息
        ///// </summary>
        ///// <param name="source"></param>
        ///// <param name="route"></param>
        ///// <returns></returns>
        //[HttpGet("{id}")]
        //[SwaggerResponse(200, "", typeof(NewsResponse))]
        //public async Task<IActionResult> GetNewsAsync([FromHeader]String source,
        //                                              [FromRoute]SiteIdRoute route) {
        //    var response = new Response<NewsResponse>();
        //    try {
        //        var request = new GetDescriptor<WebNewsDoc>(_IWebNewsElastic.IndexName, route.id);
        //        // 排除返回字段
        //        request.SourceExcludes(a => new { a.Img, a.ImagePath, a.DisplayType });
        //        // 只获取元数据
        //        var result = await this._IWebNewsElastic.Client
        //                                                .GetAsync<NewsResponse>(request);
        //        if (result.ApiCall.Success && result.ApiCall.HttpStatusCode == 200) {
        //            if (!string.IsNullOrEmpty(result.Source.NewsId)) {
        //                response.Code = true;
        //                response.Data = result.Source;
        //            }
        //            else
        //                return NotFound();
        //        }
        //        else {
        //            return NotFound();
        //        }
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }
        //    return response.ToHttpResponse();
        //}
    }
}