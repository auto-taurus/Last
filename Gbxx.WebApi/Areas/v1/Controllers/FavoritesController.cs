using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Gbxx.WebApi.Areas.v1.Models.Route;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [HiddenApi]
    [Route("v1")]
    public class FavoritesController : AuthorizeController {

        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberFavoritesRepository _IMemberFavoritesRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="memberInfoRepository"></param>
        public FavoritesController(ILogger<SiteController> logger,
                                IMemberFavoritesRepository memberFavoritesRepository) {
            this._ILogger = logger;
            this._IMemberFavoritesRepository = memberFavoritesRepository;

        }

        /// <summary>
        /// 获取会员收藏列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("Member/{id}/Favorites")]
        [SwaggerResponse(200, "", typeof(MemberAppDto))]
        public async Task<IActionResult> GetMemberFavoritesAsync([FromHeader]String source,
                                                        [FromRoute]IdRoute route) {
            var response = new Response<MemberAppDto>();
            try {
                var entity = await _IMemberFavoritesRepository.SingleAsync(e => e.MemberId == Convert.ToInt32(route.id));
                if (entity != null) {
                    response.Code = true;
                    //response.Data.MemberId = entity.MemberId;
                    //response.Data.Phone = entity.Phone;
                    //response.Data.NickName = entity.NickName;
                    //response.Data.Name = entity.Name;
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
        /// 会员收藏提交
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpPost("Member/{id}/Favorites")]
        [SwaggerResponse(200, "", typeof(MemberAppDto))]
        public async Task<IActionResult> PostMemberFavoritesAsync([FromHeader]String source,
                                                        [FromRoute]IdRoute route) {
            var response = new Response<MemberAppDto>();
            try {
                var entity = await _IMemberFavoritesRepository.SingleAsync(e => e.MemberId == Convert.ToInt32(route.id));
                if (entity != null) {
                    response.Code = true;
                    //response.Data.MemberId = entity.MemberId;
                    //response.Data.Phone = entity.Phone;
                    //response.Data.NickName = entity.NickName;
                    //response.Data.Name = entity.Name;
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