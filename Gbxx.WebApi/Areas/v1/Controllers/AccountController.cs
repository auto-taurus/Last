using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Auto.EFCore.Entities;
using Auto.RedisServices.Repositories;
using Gbxx.WebApi.Areas.v1.Models.Post;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase {

        protected readonly ILogger _ILogger;
        protected IWebNewsRedis _IWebNewsRedis;
        protected IMemberInfoRepository _IMemberInfoRepository;
        public AccountController(ILogger<SiteController> logger,
                                 IWebNewsRedis webNewsRedis,
                                 IMemberInfoRepository memberInfoRepository) {
            this._IWebNewsRedis = webNewsRedis;
            this._IMemberInfoRepository = memberInfoRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("RefreshToken")]
        public async Task<IActionResult> GetLoginTokenAsync([FromHeader]String source,
                                                            [FromQuery]LoginPost item) {
            var response = new Response<Object>();
            try {

                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("Login")]
        public async Task<IActionResult> PostUserLoginAsync(
            [FromQuery]String source,
                                                            [FromBody]LoginPost item) {
            var response = new Response<Object>();
            try {
                var entity = new MemberInfo();
                if (item.LoginMethods == 0)
                    entity = await _IMemberInfoRepository.SingleAsync(a => a.Phone == item.LoginName && a.Password == item.Password && a.IsEnbale == 1);
                else if (item.LoginMethods == 1) {
                    entity = await _IMemberInfoRepository.SingleAsync(a => a.Wechat == item.LoginName && a.IsEnbale == 1);
                }
                if (entity != null) {
                    response.Code = true;
                }
                else {
                    return NotFound();
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("LoginOut")]
        public async Task<IActionResult> PostUserLoginOutAsync([FromQuery]String source,
                                                               [FromBody]LoginPost item) {
            var response = new Response<Object>();
            try {

                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}