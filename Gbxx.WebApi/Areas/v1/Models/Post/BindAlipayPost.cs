using Auto.DataServices.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Post {
    /// <summary>
    /// 绑定支付宝接收类
    /// </summary>
    public class BindAlipayPost {
        /// <summary>
        /// 会员id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 支付宝
        /// </summary>
        public string Alipay { get; set; }
    }

    /// <summary>
    /// 数据校验
    /// </summary>
    public class BindAlipayPostValidator : AbstractValidator<BindAlipayPost> {
        protected IMemberInfosRepository _IMemberInfoRepository;
        public BindAlipayPostValidator(IMemberInfosRepository memberInfoRepository) {
            this._IMemberInfoRepository = memberInfoRepository;

            //检查用户是否存在
            RuleFor(x => x.Id).NotEmpty().WithMessage("用户id不能为空").MustAsync(async (id, cancellation) => {
                bool exists = await this._IMemberInfoRepository.IsExistAsync(x => x.MemberId == id);
                return exists;
            }).WithMessage("当前用户不存在，请检查");

            RuleFor(x => x.Name).NotEmpty().WithMessage("真实姓名不为空").Matches(@"[\u4E00-\u9FA5]+").WithMessage("真实姓名必须为中文");
            RuleFor(x => x.Alipay).NotEmpty().WithMessage("支付宝账号不能为空").Matches(@"0?(13|14|15|17|18|19)[0-9]{9}").WithMessage("支付宝账号格式不正确");

            //检查账号是否在其他账户绑定过
            RuleFor(x => new { x.Id, x.Alipay }).MustAsync(async (obj, collback) => {
                bool exists = await this._IMemberInfoRepository.IsExistAsync(x => x.Alipay == obj.Alipay&&x.MemberId!=obj.Id);
                return !exists;
            }).WithMessage("该账号已在其他用户绑定过");

            //不能更新绑定，检测用户是否绑定过 已绑定则无法更改绑定
            RuleFor(x => x.Id).MustAsync(async (id, collback) => {
                var flag = false;
                var entity = await this._IMemberInfoRepository.FirstOrDefaultAsync(x => x.MemberId == id);
                if (string.IsNullOrWhiteSpace(entity.Alipay)) {
                    flag = true;
                }
                return flag;
            }).WithMessage("每个用户只允许绑定一次(当前用户已绑定)");
        }
    }
}
