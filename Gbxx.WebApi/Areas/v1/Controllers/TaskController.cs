using Auto.Applications.Contracts.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1/[controller]")]
    public partial class TaskController : AuthorizeController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected ITaskInfoApp _ITaskInfoApp;
        /// <summary>
        /// 
        /// </summary>
        protected ITaskInfoRepository _ITaskInfoRepository;
        /// <summary>
        /// 
        /// </summary>
        protected ISystemDictionaryRepository _ISystemDictionaryRepository;
        public TaskController(ILogger<SiteController> logger,
                              ISystemDictionaryRepository systemDictionaryRepository,
                              ITaskInfoApp taskInfoApp) {
            this._ILogger = logger;
            this._ISystemDictionaryRepository = systemDictionaryRepository;
            this._ITaskInfoApp = taskInfoApp;
        }

        /// <summary>
        /// 获取任务种类信息(此Id为字典TypeKey)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{Code}/List")]
        public async Task<IActionResult> GetIncomeAsync([FromHeader]String source,
                                                        [FromRoute]RouteIdString route) {
            var response = new Response<Object>();
            try {
                var dists = await _ISystemDictionaryRepository.GetKeyNames(route.id);
                if (dists.Count > 0) {
                    var types = dists.Select(a => int.Parse(a.DistKey)).ToList();
                    await _ITaskInfoRepository.GetDists(types);
                    response.Code = true;
                    response.Data = new {
                        Dists = dists,
                        Problems = ""
                    };
                }
                else
                    return NoContent();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 全站任务入口
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public async Task<IActionResult> PostTaskAsync([FromHeader]String source,
                                                       [FromRoute]RouteCode route) {
            var response = new Response<Object>();
            try {

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }

    }
}