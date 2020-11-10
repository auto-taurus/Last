using Auto.DataServices.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Post {
    public class MemberInfoPost {
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别（0男，1女）
        /// </summary>
        public int? Sex { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 支付宝
        /// </summary>

        public string Alipay { get; set; }
    }
    public class MemberInfoPostValidator : AbstractValidator<MemberInfoPost> {
        protected readonly IMemberInfosRepository _IMemberInfosRepository;
        public MemberInfoPostValidator(IMemberInfosRepository memberInfosRepository) {
            this._IMemberInfosRepository = memberInfosRepository;
            RuleFor(x => x.Alipay).MustAsync(async (a, cancellation) => {
                return await _IMemberInfosRepository.IsExistAsync(b => b.Alipay == a);
            }).WithMessage("支付宝已被绑定!");
        }
    }
}
