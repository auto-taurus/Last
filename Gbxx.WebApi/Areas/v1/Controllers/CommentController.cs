using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Linq;
using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models.Post;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1")]
    public class CommentController : AuthorizeController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberCommentRepository _IMemberCommentRepository;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberCommentUpRepository _IMemberCommentUpRepository;
        public CommentController(ILogger<CommentController> logger,
                                 IMemberCommentRepository memberCommentRepository,
                                 IMemberCommentUpRepository memberCommentUpRepository) {
            this._ILogger = logger;
            this._IMemberCommentRepository = memberCommentRepository;
            this._IMemberCommentUpRepository = memberCommentUpRepository;
        }
        /// <summary>
        /// 获取单个评论列表信息（二级评论）
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("Comment/{id}")]
        public async Task<IActionResult> GetCommentAsync([FromHeader]String source,
                                                         [FromRoute]IdIntRoute route,
                                                         [FromQuery]PagerBase item) {
            var response = new Response<Object>();
            try {
                var express = Express.Begin<MemberComment>(true);
                express = express.And(a => a.ParentId == route.id && a.IsEnable == 1);

                var result = await _IMemberCommentRepository.Query(express)
                                                            .OrderBy(a => a.CommentTime)
                                                            .ToPager(item.PageIndex.Value, item.PageSize.Value)
                                                            .Select(a => new {
                                                                CommentId = a.CommentId,
                                                                NewsId = a.NewsId,
                                                                ParentId = a.ParentId,
                                                                MemberId = a.MemberId,
                                                                MemberName = a.MemberName,
                                                                CommentBody = a.CommentBody,
                                                                CommentTime = a.CommentTime,
                                                                QuoteId = a.QuoteId,
                                                                QuoteName = a.QuoteName,
                                                                Up = a.Up,
                                                                IsUp = a.MemberCommentUps.Any(b => b.MemberId == MemberId)
                                                            })
                                                            .ToListAsync();
                if (result.Count <= 0) {
                    return NoContent();
                }
                else {
                    response.Code = true;
                    response.Data = result;
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 评论点赞
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpPost("Comment/{id}/Up")]
        public async Task<IActionResult> PostCommentUpAsync([FromHeader]String source,
                                                            [FromRoute]IdIntRoute route) {
            var response = new Response<Object>();
            try {
                if (await _IMemberCommentUpRepository.IsExistAsync(a => a.CommentId == route.id && a.MemberId == MemberId))
                    return BadRequest("已赞，无需再次点赞！");
                var result = await _IMemberCommentUpRepository.AddAsync(new MemberCommentUp() {
                    CommentId = route.id,
                    MemberId = MemberId
                });
                await _IMemberCommentRepository.IncrementUp(route.id);
                await _IMemberCommentRepository.SaveChangesAsync();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }

        /// <summary>
        /// 获取新闻评论信息(一级评论)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet("News/{id}/Comment")]
        public async Task<IActionResult> GetMemberCommentAsync([FromHeader]String source,
                                                               [FromRoute]IdStringRoute route,
                                                               [FromQuery]PagerBase item) {
            var response = new Response<Object>();
            try {
                var express = Express.Begin<MemberComment>(true);
                express = express.And(a => a.NewsId == route.id && a.ParentId == 0 && a.IsEnable == 1);

                var result = await _IMemberCommentRepository.Query(express)
                                                            .OrderBy(a => a.CommentTime)
                                                            .ToPager(item.PageIndex.Value, item.PageSize.Value)
                                                            .Select(a => new {
                                                                CommentId = a.CommentId,
                                                                NewsId = a.NewsId,
                                                                ParentId = a.ParentId,
                                                                MemberId = a.MemberId,
                                                                MemberName = a.MemberName,
                                                                CommentBody = a.CommentBody,
                                                                CommentTime = a.CommentTime,
                                                                QuoteId = a.QuoteId,
                                                                QuoteName = a.QuoteName,
                                                                Up = a.Up,
                                                                Number = a.Number,
                                                                IsUp = a.MemberCommentUps.Any(b => b.MemberId == MemberId)
                                                            })
                                                            .ToListAsync();
                if (result.Count <= 0) {
                    return NoContent();
                }
                else {
                    response.Code = true;
                    response.Data = result;
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 发表新闻评论
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("News/{id}/Comment")]
        public async Task<IActionResult> PostMemberCommentAsync([FromHeader]String source,
                                                                [FromRoute]IdStringRoute route,
                                                                [FromBody]CommentPost item) {
            var response = new Response<Object>();
            try {
                if (item.ParentId.HasValue) {
                    await _IMemberCommentRepository.IncrementComment(item.ParentId.Value);
                }
                var entity = new MemberComment();

                entity.NewsId = route.id;
                entity.ParentId = item.ParentId.HasValue ? item.ParentId : 0;
                entity.MemberId = item.MemberId;
                entity.MemberName = item.MemberName;
                entity.QuoteId = item.QuoteId;
                entity.QuoteName = item.QuoteName;
                entity.CommentBody = item.CommentBody;
                entity.CommentTime = System.DateTime.Now;
                entity.Up = 0;
                entity.Number = 0;
                entity.IsEnable = 1;
                await _IMemberCommentRepository.AddAsync(entity);
                await _IMemberCommentRepository.SaveChangesAsync();

                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}