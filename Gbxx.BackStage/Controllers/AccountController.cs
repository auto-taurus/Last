using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons;
using Auto.Commons.ApiHandles.Responses;
using Auto.RedisServices.Repositories;
using Gbxx.BackStage.Areas.v1.Controllers;
using Gbxx.BackStage.Models.Post;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gbxx.BackStage.Controllers {
    [Route("v1/[controller]")]
    public class AccountController : DefaultController {
        private readonly ILogger _ILogger;
        protected IJwtRedis _IJwtRedis;
        public AccountController(ILogger<SystemMenuController> logger,
                                 IJwtRedis jwtRedis) {
            this._ILogger = logger;
            this._IJwtRedis = jwtRedis;
        }
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <returns></returns>
        [HttpGet("Code")]
        public IActionResult GetVerifyCodeAsync() {
            var response = new Response<Object>();
            try {
                YzmHelper yzm = new YzmHelper(RandType.Letters, 6, 20, 36);
                yzm.CreateImage();
                HttpContext.Session.SetString("VerifyCode", yzm.Text);

                response.Code = true;
                response.Data = yzm.CreateBase64String();
            }
            catch (Exception ex) {

            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("Login")]
        public async Task<IActionResult> PostLoginAsync(LoginUserPost item) {
            try {

            }
            catch (Exception ex) {
            }
            return Ok();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="source"></param>
        /// <param name="authorization"></param>
        /// <returns></returns>
        [HttpPost("Exit")]
        public async Task<IActionResult> PostExitAsync([FromHeader]String source,
                                                       [FromHeader]String authorization) {
            var response = new Response<Object>();
            try {
                response.Code = await _IJwtRedis.DeactivateCurrentAsync();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}