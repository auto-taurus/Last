using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Handlers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1/[controller]")]
    public class DictionaryController : DefaultController {

        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;

        /// <summary>
        /// 
        /// </summary>
        protected ISystemDictionaryRepository _ISystemDictionaryRepository;
        public DictionaryController(ILogger<CommentController> logger,
                                    ISystemDictionaryRepository systemDictionaryRepository) {
            this._ILogger = logger;
            this._ISystemDictionaryRepository = systemDictionaryRepository;
        }
        /// <summary>
        /// 获取字典信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HiddenApi]
        [HttpGet("id")]
        public async Task<IActionResult> GetCommentAsync([FromHeader]String source,
                                                         [FromRoute]RouteIdString route) {
            var response = new Response<Object>();
            try {
                var dists = await _ISystemDictionaryRepository.GetKeyNames(route.id);
                if (dists.Count <= 0) {
                    return NoContent();
                }
                else {
                    response.Code = true;
                    response.Data = dists;
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}