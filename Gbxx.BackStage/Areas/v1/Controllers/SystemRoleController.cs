using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Gbxx.BackStage.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gbxx.BackStage.Areas.v1.Controllers {
    [Route("v1/[controller]")]
    public class SystemRoleController : AuthorizeController {
        private readonly ILogger _ILogger;
        public SystemRoleController(ILogger<SystemRoleController> logger) {
            this._ILogger = logger;
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetSystemRoleAsync() {
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