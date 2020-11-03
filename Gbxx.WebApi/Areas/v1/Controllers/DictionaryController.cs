using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Handlers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1")]
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
        /// 获取当个字典信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("Dictionary/{id}")]
        public async Task<IActionResult> GetDictionaryAsync([FromHeader]String source,
                                                        [FromRoute]RouteIdInt route) {
            var response = new Response<Object>();
            try {
                var dictionary = await _ISystemDictionaryRepository.Query(a => a.DictionaryId == route.id && a.IsEnable == 1)
                                                                   .Select(a => new {
                                                                       a.DictionaryId,
                                                                       a.TypeKey,
                                                                       a.DistKey,
                                                                       a.DistName,
                                                                       a.DistValue
                                                                   })
                                                                   .SingleOrDefaultAsync();
                if (dictionary != null) {
                    response.Data = dictionary;
                }
                else
                    return NotFound();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 根据字典表中TypeKey获取字典集合
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        /// <summary>
        [HttpGet("Dictionaries/{typeKey}")]
        public async Task<IActionResult> GetDictionariesAsync([FromHeader]String source,
                                                              [FromRoute]RouteTypeKey route) {
            var response = new Response<Object>();
            try {
                var dists = await _ISystemDictionaryRepository.GetKeyNames(route.typeKey);
                if (dists.Count > 0) {
                    response.Data = dists;
                }
                else
                    return NoContent();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }

    }
}