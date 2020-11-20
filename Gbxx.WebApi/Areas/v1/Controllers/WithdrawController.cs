using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Systems;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using Gbxx.WebApi.Areas.v1.Models.Post;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Handlers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {

    [Route("v1")]
    public class WithdrawController : AuthorizeController {

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

        protected IMemberWithdrawRepository _IMemberWithdrawRepository;
        /// <summary>
        /// 
        /// </summary>
        private readonly IConfiguration _IConfiguration;

        private readonly int _Before;
        private readonly int _After;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="memberInfoRepository"></param>
        /// <param name="memberIncomeRepository"></param>
        /// <param name="configuration"></param>
        public WithdrawController(ILogger<MemberWithdraw> logger,
                                IMemberInfosRepository memberInfoRepository,
                                IMemberIncomeRepository memberIncomeRepository,
                                IMemberWithdrawRepository memberWithdrawRepository,
                                IConfiguration configuration) {
            this._IConfiguration = configuration;
            this._ILogger = logger;
            this._IMemberInfoRepository = memberInfoRepository;
            this._IMemberIncomeRepository = memberIncomeRepository;
            this._IMemberWithdrawRepository = memberWithdrawRepository;
            this._Before = Convert.ToInt32(_IConfiguration["ExchangeRatio:Before"]);
            this._After = Convert.ToInt32(_IConfiguration["ExchangeRatio:After"]);

        }


        /// <summary>
        /// 会员提现扣金币
        /// </summary>
        /// <param name="source"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost("Member/Withdraws")]
        public async Task<IActionResult> PostMemberWithdrawIncomeAsync([FromHeader]String source,
                                                                                                                    [FromBody]MemberWithdrawPost item) {
            var response = new Response<object>();
            try {
                var memberInfo = await _IMemberInfoRepository.FirstOrDefaultAsync(a => a.MemberId == item.id && a.IsEnable == 1);
                if (memberInfo != null) {
                    //更新用户金币
                    memberInfo.Beans -= item.beans;
                    memberInfo.BeansTotals -= item.beans;
                    _IMemberInfoRepository.Update(memberInfo);

                    //插入会员提现记录
                    await _IMemberWithdrawRepository.AddAsync(new MemberWithdraw {
                        WithdrawId = new SnowFlake().GetLongId(),
                        MemberId = memberInfo.MemberId,
                        Methods = item.methods,
                        Title = "提现扣金币",
                        Beans = item.beans,
                        Amount = Convert.ToDecimal(item.beans) / Convert.ToDecimal(_Before),
                        Proportion = $"{_Before}/{_After}",
                        CreateTime = DateTime.Now,
                        Audit="admin",
                        AuditId=1,
                        AuditTime=DateTime.Now,
                        Status = 1
                    });
                    int flag = _IMemberInfoRepository.SaveChanges();//保存Db
                    if (flag > 0) {
                        response.Code = true;
                        response.Message = "Success";
                    }
                }

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}