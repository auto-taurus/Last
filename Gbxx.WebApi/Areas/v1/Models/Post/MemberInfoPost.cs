using Auto.DataServices.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
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
        [DefaultValue("")]
        public string Phone { get; set; }
        /// <summary>
        /// 支付宝
        /// </summary>
        public string Alipay { get; set; }

        /// <summary>
        /// 是否注销 (0是 ,1 否)
        /// </summary>
        public int IsEnable { get; set; } = 1;
    }
    public class MemberInfoPostValidator : AbstractValidator<MemberInfoPost> {
        protected readonly IMemberInfosRepository _IMemberInfosRepository;
        public MemberInfoPostValidator(IMemberInfosRepository memberInfosRepository) {
            this._IMemberInfosRepository = memberInfosRepository;
            When(x => x.IsEnable != 0, () => {
                RuleFor(x => x.Alipay).Matches(@"0?(13|14|15|17|18|19)[0-9]{9}").WithMessage("支付宝账号格式不正确")
                                 .MustAsync(AlipayRepeatValidator).WithMessage("支付宝已被绑定!");
            });
           
        }
        private async Task<bool> AlipayRepeatValidator(string alipay, CancellationToken cancellation) {
            return !await _IMemberInfosRepository.IsExistAsync(b => b.Alipay == alipay);
        }

    }
}
