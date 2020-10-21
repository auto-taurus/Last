using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Auto.Entities.Dtos;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [HiddenApi]
    [Route("v1/[controller]")]
    public class WithdrawConfigController : AuthorizeController {
      
        /// <summary>
        /// 获取提现配置
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet]
        [SwaggerResponse(200, "", typeof(MemberAppDto))]
        public async Task<IActionResult> GetIncomeAsync([FromHeader]String source) {
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