using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models.Route;
using Gbxx.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
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
        /// <param name="logger"></param>
        /// <param name="memberInfoRepository"></param>
        public MemberController(ILogger<SiteController> logger,
                                IMemberInfosRepository memberInfoRepository) {
            this._ILogger = logger;
            this._IMemberInfoRepository = memberInfoRepository;

        }
        /// <summary>
        /// 会员信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> GetMemberInfoAsync([FromHeader]String source,
                                                            [FromRoute]IdRoute route) {
            var response = new Response<MemberData>();
            try {
                var entity = await _IMemberInfoRepository.SingleAsync(e => e.MemberId == Convert.ToInt32(route.id));
                if (entity != null) {
                    response.Code = true;
                    response.Data.MemberId = entity.MemberId;
                    response.Data.Phone = entity.Phone;
                    response.Data.NickName = entity.NickName;
                    response.Data.Name = entity.Name;
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
        /// 获取会员关注列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Follow")]
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> GetFollowAsync([FromHeader]String source,
                                                        [FromRoute]IdRoute route) {
            var response = new Response<MemberData>();
            try {
                var entity = await _IMemberInfoRepository.SingleAsync(e => e.MemberId == Convert.ToInt32(route.id));
                if (entity != null) {
                    response.Code = true;
                    response.Data.MemberId = entity.MemberId;
                    response.Data.Phone = entity.Phone;
                    response.Data.NickName = entity.NickName;
                    response.Data.Name = entity.Name;
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
        /// 获取会员收藏列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Favorites")]
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> GetFavoritesAsync([FromHeader]String source,
                                                        [FromRoute]IdRoute route) {
            var response = new Response<MemberData>();
            try {
                var entity = await _IMemberInfoRepository.SingleAsync(e => e.MemberId == Convert.ToInt32(route.id));
                if (entity != null) {
                    response.Code = true;
                    response.Data.MemberId = entity.MemberId;
                    response.Data.Phone = entity.Phone;
                    response.Data.NickName = entity.NickName;
                    response.Data.Name = entity.Name;
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
        /// 获取会员足迹列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{id}/Footprint")]
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> GetFootprintAsync([FromHeader]String source,
                                                        [FromRoute]IdRoute route) {
            var response = new Response<MemberData>();
            try {
                var entity = await _IMemberInfoRepository.SingleAsync(e => e.MemberId == Convert.ToInt32(route.id));
                if (entity != null) {
                    response.Code = true;
                    response.Data.MemberId = entity.MemberId;
                    response.Data.Phone = entity.Phone;
                    response.Data.NickName = entity.NickName;
                    response.Data.Name = entity.Name;
                }
                else
                    return NotFound();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }

}