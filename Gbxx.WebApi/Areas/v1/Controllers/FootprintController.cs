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
    public class FootprintController : AuthorizeController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberFootprintRepository _IMemberFootprintRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="memberInfoRepository"></param>
        public FootprintController(ILogger<SiteController> logger,
                                IMemberFootprintRepository memberFootprintRepository) {
            this._ILogger = logger;
            this._IMemberFootprintRepository = memberFootprintRepository;

        }
        /// <summary>
        /// 获取会员足迹列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("Member/{id}/Footprint")]
        [SwaggerResponse(200, "", typeof(MemberAppDto))]
        public async Task<IActionResult> GetFootprintAsync([FromHeader]String source,
                                                        [FromRoute]IdRoute route) {
            var response = new Response<MemberAppDto>();
            try {
                var entity = await _IMemberFootprintRepository.SingleAsync(e => e.MemberId == Convert.ToInt32(route.id));
                if (entity != null) {
                    response.Code = true;
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
        /// 会员足迹提交
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpPost("Member/{id}/Footprint")]
        [SwaggerResponse(200, "", typeof(MemberAppDto))]
        public async Task<IActionResult> PostMemberFootprintAsync([FromHeader]String source,
                                                        [FromRoute]IdRoute route) {
            var response = new Response<MemberAppDto>();
            try {
                var entity = await _IMemberFootprintRepository.SingleAsync(e => e.MemberId == Convert.ToInt32(route.id));
                if (entity != null) {
                    response.Code = true;
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