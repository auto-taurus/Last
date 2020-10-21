using Auto.Commons.ApiHandles.Responses;
using Auto.Entities.Dtos;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Handlers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {

    [HiddenApi]
    [Route("v1")]
    public class WithdrawController : AuthorizeController {

        /// <summary>
        /// 获取会员提现记录列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("Member/{id}/Withdraws")]
        [SwaggerResponse(200, "", typeof(MemberAppDto))]
        public async Task<IActionResult> GetMemberWithdrawIncomeAsync([FromHeader]String source) {
            var response = new Response<MemberAppDto>();
            var d = RouteData;
            try {

            }
            catch (Exception) {
                //response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 会员提现
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpPost("Member/{id}/Withdraws")]
        [SwaggerResponse(200, "", typeof(MemberAppDto))]
        public async Task<IActionResult> PostMemberWithdrawIncomeAsync([FromHeader]String source) {
            var response = new Response<MemberAppDto>();
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