using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Linq;
using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using Gbxx.WebApi.Areas.v1.Models.Post;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1/[controller]")]
    public class MessageController : AuthorizeController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberMessageRepository _IMemberMessageRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="memberMessageRepository"></param>
        public MessageController(ILogger<MessageController> logger,
                                 IMemberMessageRepository memberMessageRepository) {
            this._ILogger = logger;
            this._IMemberMessageRepository = memberMessageRepository;

        }
        /// <summary>
        /// 获取留言信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetMessageAsync([FromHeader]String source,
                                                         [FromQuery]PagerBase item) {
            var response = new Response<Object>();
            try {
                var express = Express.Begin<MemberMessage>(true);
                express = express.And(a => a.MemberId == MemberId && a.IsEnable == 1);

                var result = await _IMemberMessageRepository.Query(express)
                                                            .OrderByDescending(a => a.CreateTime)
                                                            .ToPager(item.PageIndex.Value, item.PageSize.Value)
                                                            .Select(a => new {
                                                                MessageId = a.MessageId,
                                                                MemberId = a.MemberId,
                                                                MemberName = a.MemberName,
                                                                LeaveBody = a.LeaveBody,
                                                                LeaveType = a.LeaveType,
                                                                CreateTime = a.CreateTime
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
        /// 提交留言
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostMessageAsync([FromHeader]String source,
                                                          [FromBody]MessagePost item) {
            var response = new Response<Object>();
            try {
                var entity = new MemberMessage();

                entity.MemberId = item.MemberId;
                entity.MemberName = item.MemberName;
                entity.LeaveBody = item.LeaveBody;
                entity.LeaveType = item.LeaveType.HasValue ? item.LeaveType : 0;
                entity.CreateTime = System.DateTime.Now;

                await _IMemberMessageRepository.AddAsync(entity);
                await _IMemberMessageRepository.SaveChangesAsync();

                response.Code = true;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}