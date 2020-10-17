using Auto.Commons;
using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Strings;
using Auto.Commons.Systems;
using Auto.DataServices.Contracts;
using Auto.Entities.Datas;
using Auto.RedisServices.Entities;
using Auto.RedisServices.Repositories;
using Gbxx.WebApi.Areas.v1.Models.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Controllers {
    [Route("v1/[controller]")]
    public class AccountController : AuthorizeController {

        protected readonly ILogger _ILogger;
        protected IWebNewsRedis _IWebNewsRedis;
        protected IJwtRedis _IJwtRedis;
        protected IMemberInfosRepository _IMemberInfosRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webNewsRedis"></param>
        /// <param name="jwtRedis"></param>
        /// <param name="memberInfosRepository"></param>
        public AccountController(ILogger<AccountController> logger,
                                 IWebNewsRedis webNewsRedis,
                                 IJwtRedis jwtRedis,
                                 IMemberInfosRepository memberInfosRepository) {
            this._ILogger = logger;
            this._IWebNewsRedis = webNewsRedis;
            this._IJwtRedis = jwtRedis;
            this._IMemberInfosRepository = memberInfosRepository;
        }

        /// <summary>
        /// 刷新Token
        /// </summary>
        /// <param name="source"></param>
        /// <param name="authorization"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("Refresh")]
        [SwaggerResponse(200, "", typeof(JwtAuthorData))]
        public async Task<IActionResult> GetRefreshAsync([FromHeader]String source,
                                                         [FromHeader]String authorization) {
            var response = new Response<JwtAuthorData>();
            try {
                var member = new MemberInfos();

                var result = await _IJwtRedis.RefreshAsync(authorization, member);
                if (result != null) {
                    response.Code = true;
                    response.Data = result;
                }
                else {
                    return BadRequest("请求刷新失败！");
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("Login")]
        [AllowAnonymous]
        [SwaggerResponse(200, "", typeof(JwtAuthorData))]
        public async Task<IActionResult> PostUserLoginAsync([FromHeader]String source,
                                                            [FromBody]LoginPost item) {
            var response = new Response<JwtAuthorData>();
            try {

                var entity = new MemberInfos();
                if (item.LoginMethods == 0) {
                    item.Password = Tools.Md5(item.Password);
                    entity = await _IMemberInfosRepository.SingleAsync(a => a.Phone == item.LoginName && a.Password == item.Password && a.IsEnbale == 1);
                }
                else if (item.LoginMethods == 1) {
                    entity = await _IMemberInfosRepository.SingleAsync(a => a.Wechat == item.LoginName && a.IsEnbale == 1);
                    if (entity == null) {
                        entity = new MemberInfos();
                        entity.Code = SnowFlake.GetInstance().GetUniqueShortId(8);
                        entity.NickName = item.NickName;
                        entity.Name = item.LoginName;
                        entity.Avatar = item.Avatar;
                        entity.Wechat = item.Wechat;
                        entity.Password = Tools.Md5("123456");
                        entity.IsEnbale = 1;
                        entity.LastLoginTime = System.DateTime.Now;
                        entity.CreateTime = System.DateTime.Now;
                        entity.Remarks = "微信首次登录注册。";

                        await _IMemberInfosRepository.AddAsync(entity);
                        await _IMemberInfosRepository.CommitChangesAsync();
                    }
                }
                if (entity != null) {
                    var result = _IJwtRedis.Create(entity);
                    if (result != null) {
                        response.Code = true;
                        response.Data = result;
                    }
                    else
                        return BadRequest("登录授权失败！");
                }
                else {
                    return NotFound("用户不存在！");
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="source"></param>
        /// <param name="authorization"></param>
        /// <returns></returns>
        [HttpPost("Exit")]
        public async Task<IActionResult> PostUserLoginOutAsync([FromHeader]String source) {
            var response = new Response<Object>();
            try {
                if (await _IJwtRedis.IsCurrentActiveTokenAsync()) {
                    response.Code = await _IJwtRedis.DeactivateCurrentAsync();
                }
                else {
                    return BadRequest("Authorization无效！");
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}