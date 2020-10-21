using Auto.Commons.ApiHandles.Responses;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1")]
    public class CommentController : AuthorizeController {
        /// <summary>
        /// 获取单个评论列表信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("Comment/{id}")]
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> GetCommentAsync([FromHeader]String source) {
            var response = new Response<MemberData>();
            try {

            }
            catch (Exception) {
                //response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 获取新闻评论信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("News/{id}/Comment")]
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> GetMemberCommentAsync([FromHeader]String source) {
            var response = new Response<MemberData>();
            try {

            }
            catch (Exception) {
                //response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 发表新闻评论
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpPost("News/{id}/Comment")]
        [SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> PostMemberCommentAsync([FromHeader]String source) {
            var response = new Response<MemberData>();
            try {

            }
            catch (Exception) {
                //response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }

    }
}