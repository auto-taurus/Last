using Auto.Commons.ApiHandles.Responses;
using Gbxx.WebApi.Areas.v1.Data;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1/Member")]
    public class IncomeController : AuthorizeController {
        /// <summary>
        /// 获取会员收入记录列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Incomes")]
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> GetMemberIncomesAsync([FromHeader]String source) {
            var response = new Response<MemberData>();
            try {

            }
            catch (Exception) {
                //response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}