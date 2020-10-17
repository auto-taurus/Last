using Auto.Commons.ApiHandles.Responses;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1/[controller]")]
    public class ProblemController : AuthorizeController {
        /// <summary>
        /// 常见问题
        /// </summary>
        public ProblemController() {

        }
        /// <summary>
        /// 获取问题列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> GetProblemAsync([FromHeader]String source) {
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