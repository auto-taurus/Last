using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Extensions.Redis;
using Gbxx.WebApi.Areas.v1.Models;
using Gbxx.WebApi.Areas.v1.Models.Get;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("V1/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {

        protected readonly ILogger _ILogger;
        protected IRedisStore _IRedisStore;
        public UsersController(ILogger<SiteController> logger, IRedisStore redisStore) {
            this._IRedisStore = redisStore;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="authorization"></param>
        /// <param name="deviceArgs"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetUserSearchAsync([FromHeader(Name = "Device-Args")]DeviceArgs deviceArgs,
                                                            [FromHeader]string authorization,
                                                            [FromQuery]UserSearchGet item) {
            var response = new Response<Object>();
            try {
               var dd = this._IRedisStore.Instance;
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
        /// <param name="deviceArgs"></param>
        /// <param name="authorization"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostUserSearchAsync([FromHeader(Name = "Device-Args")]string deviceArgs,
                                                             [FromHeader]string authorization,
                                                             [FromBody]UserSearchGet item) {
            var response = new Response<Object>();
            try {

                var dd = this._IRedisStore.GetInstance("localhost");
                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}