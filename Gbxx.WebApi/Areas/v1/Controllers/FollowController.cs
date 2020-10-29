using Auto.Commons.ApiHandles.Responses;
using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using Gbxx.WebApi.Areas.v1.Models.Get;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1")]
    public class FollowController : AuthorizeController {

        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberFollowRepository _IMemberFollowRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="memberFollowRepository"></param>
        public FollowController(ILogger<SiteController> logger,
                                IMemberFollowRepository memberFollowRepository) {
            this._ILogger = logger;
            this._IMemberFollowRepository = memberFollowRepository;

        }
        /// <summary>
        /// 获取会员关注列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("Member/{id}/Follow")]
        public async Task<IActionResult> GetMemberFollowAsync([FromHeader]String source,
                                                              [FromRoute]RouteIdInt route,
                                                              [FromQuery]MemberFollowGet item) {
            var response = new Response<Object>();
            try {
                var result = await _IMemberFollowRepository.Query(a => a.MemberId == route.id && a.IsEnable == 1,
                                                                  a => new MemberFollow(),
                                                                  true)
                                                           .ToPager(item.PageIndex.Value, item.PageSize.Value)
                                                           .ToListAsync();
                if (result.Count > 0) {
                    response.Code = true;
                    response.Data = result;
                }
                else
                    return NoContent();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 会员关注
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("Member/{id}/Follow")]
        public async Task<IActionResult> PostMemberFollowAsync([FromHeader]String source,
                                                               [FromRoute]RouteIdInt route,
                                                               [FromBody]MemberFollowPost item) {
            var response = new Response<Object>();
            try {
                if (item.OType == 1) {
                    response.Code = await _IMemberFollowRepository.BatchRemoveAsync(a => a.MemberId == route.id && a.SourceId == item.SourceId);
                }
                else {
                    await _IMemberFollowRepository.AddAsync(new MemberFollow() {
                        MemberId = route.id,
                        SourceId = item.SourceId,
                        FollowTime = System.DateTime.Now,
                        IsEnable = 1
                    });
                    await _IMemberFollowRepository.SaveChangesAsync();
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}