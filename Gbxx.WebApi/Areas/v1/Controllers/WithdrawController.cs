using Auto.Commons.ApiHandles.Responses;
using Gbxx.WebApi.Areas.v1.Data;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {

    [Route("v1/Member")]
    public class WithdrawController : AuthorizeController {
        /// <summary>
        /// 获取会员提现记录列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Withdraws")]
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
    }
}