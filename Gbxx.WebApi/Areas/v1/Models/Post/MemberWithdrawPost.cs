using Auto.DataServices.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Post {

    /// <summary>
    /// 会员体现扣金币类
    /// </summary>
    public class MemberWithdrawPost {

        /// <summary>
        /// 用户id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 金币
        /// </summary>
        public int beans { get; set; }

        /// <summary>
        /// 提现方式（0默认值、1微信、2支付宝、3手机号）
        /// </summary>
        public int methods { get; set; }

    }
    public class MemberWithdrawPostValidator : AbstractValidator<MemberWithdrawPost> {
        protected readonly IMemberInfosRepository _IMemberInfosRepository;
        public MemberWithdrawPostValidator(IMemberInfosRepository memberInfosRepository) {
            this._IMemberInfosRepository = memberInfosRepository;
            //检查用户是否存在
            RuleFor(x => x.id).NotEmpty().WithMessage("用户id不能为空").MustAsync(async (id, cancellation) => {
                bool exists = await this._IMemberInfosRepository.IsExistAsync(x => x.MemberId == id);
                return exists;
            }).WithMessage("当前用户不存在，请检查");
        }
    }
}
