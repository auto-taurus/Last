using Auto.Applications.Contracts.Tasks;
using Auto.Applications.Modals;
using Auto.Commons;
using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using Auto.RedisServices.Repositories;
using FluentValidation.Results;
using Gbxx.WebApi.Areas.v1.Models.Post;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Handlers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    /// <summary>
    /// 会员中心
    /// </summary>
    [Route("v1/[controller]")]
    public class MemberController : AuthorizeController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberInfosRepository _IMemberInfoRepository;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberIncomeRepository _IMemberIncomeRepository;
        /// <summary>
        /// 
        /// </summary>
        protected IJwtRedis _IJwtRedis;
        /// <summary>
        /// 
        /// </summary>
        protected ITaskInfoApp _ITaskInfoApp;

        private readonly IConfiguration _IConfiguration;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="memberInfoRepository"></param>
        /// <param name="memberIncomeRepository"></param>
        /// <param name="jwtRedis"></param>
        /// <param name="configuration"></param>
        /// <param name="taskInfoApp"></param>
        public MemberController(ILogger<SiteController> logger,
                                IMemberInfosRepository memberInfoRepository,
                                IMemberIncomeRepository memberIncomeRepository,
                                IJwtRedis jwtRedis,
                                IConfiguration configuration,
                                ITaskInfoApp taskInfoApp) {
            this._IConfiguration = configuration;
            this._ILogger = logger;
            this._IMemberInfoRepository = memberInfoRepository;
            this._IMemberIncomeRepository = memberIncomeRepository;
            this._IJwtRedis = jwtRedis;
            this._ITaskInfoApp = taskInfoApp;

        }
        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse(200, "", typeof(MemberAppDto))]
        public async Task<IActionResult> GetMemberInfoAsync([FromHeader]String source,
                                                            [FromRoute]RouteIdInt route) {
            var response = new Response<MemberAppDto>();
            try {
                var entity = await _IMemberInfoRepository.GetAppInfo(route.id);
                if (entity != null) {
                    entity.TodayRead = await _IMemberIncomeRepository.Query(a => a.MemberId == route.id
                                                                            && a.TaskCode == "T0003"
                                                                            && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd")
                                                                            && a.Status == 0)
                                                                      .SumAsync(a => a.ReadTime);
                    entity.TodayBeans = await _IMemberIncomeRepository.Query(a => a.MemberId == route.id
                                                                             && a.CreateTime.Value.ToString("yyyy-MM-dd") == System.DateTime.Now.ToString("yyyy-MM-dd")
                                                                             && a.Status == 0)
                                                                      .SumAsync(a => a.Beans);
                    var before = Convert.ToDecimal(_IConfiguration["ExchangeRatio:Before"]);
                    var after = Convert.ToInt32(_IConfiguration["ExchangeRatio:After"]);
                    entity.Ratio = $"{before}/{after}";
                    entity.RatioValue = after / before;
                    response.Code = true;
                    response.Data = entity;
                }
                else
                    return NotFound();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 修改会员信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("{id}")]
        public async Task<IActionResult> PostMemberInfoAsync([FromHeader]String source,
                                                             [FromRoute]RouteIdInt route,
                                                             [FromBody]MemberInfoPost item) {
            var response = new Response<Object>();
            try {
                if (await _IMemberInfoRepository.IsExistAsync(a => a.MemberId == route.id && a.IsEnable == 1)) {
                    var entity = await _IMemberInfoRepository.FirstOrDefaultAsync(a => a.MemberId == route.id);
                    if (!string.IsNullOrEmpty(item.NickName))
                        entity.NickName = item.NickName;
                    if (item.Sex.HasValue)
                        entity.Sex = item.Sex;
                    if (!string.IsNullOrEmpty(item.Phone))
                        entity.Phone = item.Phone;
                    if (!string.IsNullOrEmpty(item.Name))
                        entity.Name = item.Name;
                    if (!string.IsNullOrEmpty(item.Alipay)) {
                        entity.Alipay = item.Alipay;
                        await _ITaskInfoApp.AddTasks("T0004", new TaskItem() {
                            MemberId = entity.MemberId,
                            InvitedId = 0,
                            FromMark = 0
                        });
                    }
                    _IMemberInfoRepository.Update(entity);
                    response.Code = await _IMemberInfoRepository.SaveChangesAsync() > 0;
                }
                else
                    return NotFound();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 会员修改密码
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("{id}/Password")]
        public async Task<IActionResult> PostMemberInfoPasswordAsync([FromHeader]String source,
                                                                     [FromRoute]RouteIdInt route,
                                                                     [FromBody]PasswordPost item) {
            var response = new Response<Object>();
            try {
                var flag = await _IMemberInfoRepository.BatchUpdateAsync(a => a.MemberId == route.id,
                    u => new MemberInfos() {
                        Password = Tools.Md5(item.New)
                    });
                if (flag) {
                    response.Code = true;
                    await _IJwtRedis.DeactivateCurrentAsync();
                }
                else
                    return BadRequest("修改密码失败！");
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 上传会员头像
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="avatar"></param>
        /// <returns></returns>
        [HttpPost("{id}/Avatar")]
        [HiddenApi]
        public async Task<IActionResult> PostMemberInfoAvatarAsync([FromHeader]String source,
                                                                   [FromRoute]RouteIdInt route,
                                                                   [FromBody]String avatar) {
            var response = new Response<Object>();
            try {
                if (string.IsNullOrEmpty(avatar))
                    return BadRequest("请传递头像文件！");
                else {

                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }

        /// <summary>
        /// 绑定支付宝
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> BindAlipayAsync([FromHeader]String source,
                                                                   [FromBody]BindAlipayPost item) {
            var response = new Response<Object>();
            try {
                response.Code = await _IMemberInfoRepository.BatchUpdateAsync(x => x.MemberId == item.Id, a => new MemberInfos {
                    Name = item.Name,
                    Alipay = item.Alipay
                });
                response.Message = response.Code ? "绑定成功" : "绑定失败";
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}