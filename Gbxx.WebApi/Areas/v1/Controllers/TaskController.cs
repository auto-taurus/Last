using Auto.Commons.ApiHandles.Responses;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1/[controller]")]
    public partial class TaskController : AuthorizeController {
        public TaskController() {

        }
        /// <summary>
        /// 获取任务种类信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Category")]
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> GetIncomeAsync([FromHeader]String source) {
            var response = new Response<MemberData>();
            var d = RouteData;
            try {

            }
            catch (Exception) {
                //response.SetError(ex, this._ILogger);
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
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> PostTaskAsync([FromHeader]String source) {
            var response = new Response<MemberData>();
            var d = RouteData;
            try {

            }
            catch (Exception) {
                //response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }

    }
}