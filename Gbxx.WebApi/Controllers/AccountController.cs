using Auto.Applications.Contracts.Tasks;
using Auto.Applications.Modals;
using Auto.Commons;
using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Systems;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using Auto.RedisServices.Modals;
using Auto.RedisServices.Repositories;
using Gbxx.WebApi.Areas.v1.Models.Post;
using Gbxx.WebApi.Handlers;
using Gbxx.WebApi.Models.Post;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Controllers {
    [Route("v1/[controller]")]
    public class AccountController : AuthorizeController {

        protected readonly ILogger _ILogger;
        protected IWebNewsRedis _IWebNewsRedis;
        protected IJwtRedis _IJwtRedis;
        protected IMemberInfosRepository _IMemberInfosRepository;
        private readonly IHttpContextAccessor _IHttpContextAccessor;
        /// <summary>
        /// 
        /// </summary>
        protected ITaskInfoRepository _ITaskInfoRepository;
        protected ITaskNoviceLogRepository _ITaskNoviceLogRepository;
        /// <summary>
        /// 
        /// </summary>
        protected ITaskInfoApp _ITaskInfoApp;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webNewsRedis"></param>
        /// <param name="jwtRedis"></param>
        /// <param name="memberInfosRepository"></param>
        /// <param name="httpContextAccessor"></param>
        public AccountController(ILogger<AccountController> logger,
                                 IWebNewsRedis webNewsRedis,
                                 IJwtRedis jwtRedis,
                                 IMemberInfosRepository memberInfosRepository,
                                 IHttpContextAccessor httpContextAccessor,
                                 ITaskInfoRepository taskInfoRepository,
                                 ITaskNoviceLogRepository taskNoviceLogRepository,
                                 ITaskInfoApp taskInfoApp) {
            this._ILogger = logger;
            this._IWebNewsRedis = webNewsRedis;
            this._IJwtRedis = jwtRedis;
            this._IMemberInfosRepository = memberInfosRepository;
            this._IHttpContextAccessor = httpContextAccessor;
            this._ITaskInfoRepository = taskInfoRepository;
            this._ITaskNoviceLogRepository = taskNoviceLogRepository;
            this._ITaskInfoApp = taskInfoApp;
        }

        /// <summary>
        /// 刷新Token（暂时不做，Token默认7天失效）
        /// </summary>
        /// <param name="source"></param>
        /// <param name="authorization"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HiddenApi]
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
                item.Password = Tools.Md5(item.Password);
                var entity = await _IMemberInfosRepository.FirstOrDefaultAsync(a => a.Phone == item.LoginName && a.Password == item.Password && a.IsEnable == 1);
                if (entity != null) {
                    var result = _IJwtRedis.Create(entity);
                    if (result != null) {
                        await _IMemberInfosRepository.BatchUpdateAsync(a => a.MemberId == entity.MemberId,
                            a => new MemberInfos() {
                                LastLoginTime = System.DateTime.Now
                            });
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
        public async Task<IActionResult> PostUserExitAsync([FromHeader]String source,
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

        /// <summary>
        /// 微信登录注册
        /// </summary>
        /// <param name="source"></param>
        /// <param name="authorization"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("Register")]
        [AllowAnonymous]
        public async Task<IActionResult> PostUserRegisterAsync([FromHeader]String source,
                                                               [FromHeader]String authorization,
                                                               [FromBody]RegisterPost item) {
            var response = new Response<JwtAuthorData>();
            try {
                var entity = await _IMemberInfosRepository.FirstOrDefaultAsync(a => a.Uid == item.uid && a.OpenId == item.openid && a.IsEnable == 1);
                if (entity == null) {
                    entity = new MemberInfos();
                    entity.Code = SnowFlake.GetInstance().GetUniqueShortId(8);
                    entity.NickName = item.name;
                    entity.Name = item.name;
                    entity.Sex = item.gender == "男" ? 1 : 0;
                    entity.Avatar = item.iconurl;
                    entity.Uid = item.uid;
                    entity.OpenId = item.openid;
                    entity.Password = Tools.Md5("000000");
                    entity.Beans = 0;
                    entity.BeansTotals = 0;

                    entity.NewsNumber = 0;
                    entity.FollowNumber = 0;
                    entity.FavoritesNumber = 0;
                    entity.FansNumber = 0;

                    entity.IsNoviceTask = 0;
                    entity.IsEnable = 1;
                    entity.LastLoginTime = System.DateTime.Now;
                    entity.CreateTime = System.DateTime.Now;
                    entity.Remarks = "微信首次登录注册。";

                    await _IMemberInfosRepository.AddAsync(entity);
                    await _IMemberInfosRepository.SaveChangesAsync();

                    var taskNoviceLogs = await _ITaskInfoRepository.Query(a => a.IsNoviceTask == 1 && a.IsEnable == 1)
                                                             .Select(a => new TaskNoviceLog() {
                                                                 TaskId = a.TaskId,
                                                                 CategoryFixed = a.CategoryFixed,
                                                                 CategoryDay = a.CategoryDay,
                                                                 MemberId = entity.MemberId,
                                                                 IsEnable = 1
                                                             })
                                                             .ToListAsync();
                    await _ITaskNoviceLogRepository.BatchAddAsync(taskNoviceLogs);
                    await _ITaskInfoApp.AddTasks("T0001", new TaskItem() {
                        MemberId = entity.MemberId,
                        FromMark = 0
                    });
                }
                var result = _IJwtRedis.Create(entity);
                if (result != null) {
                    //await _IJwtRedis.DeactivateAsync(authorization);
                    response.Code = true;
                    response.Message = "初始登录密码为【000000】。";
                    response.Data = result;
                }
                else {
                    return BadRequest("授权失败！");
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}