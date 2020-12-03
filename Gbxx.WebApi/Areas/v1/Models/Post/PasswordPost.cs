using Auto.Commons;
using Auto.DataServices.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Post {
    public class PasswordPost {
        /// <summary>
        /// 手机号/微信号
        /// </summary>
        /// <example></example>
        public string LoginName { get; set; }
        /// <summary>
        /// 原始密码
        /// </summary>
        /// <example></example>
        public string Old { get; set; }
        /// <summary>
        /// 新密码
        /// </summary>
        /// <example></example>
        public string New { get; set; }

        /// <summary>
        /// 确认密码
        /// </summary>
        /// <example></example>
        public string Affirm { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class PasswordPostValidator : AbstractValidator<PasswordPost> {
        protected IMemberInfosRepository _IMemberInfoRepository;

        /// <summary>
        /// 自动校验
        /// </summary>
        public PasswordPostValidator(IMemberInfosRepository memberInfoRepository) {
            this._IMemberInfoRepository = memberInfoRepository;
            RuleFor(x => x.LoginName).MustAsync(async (loginName, collback) => {
                return await _IMemberInfoRepository.IsExistAsync(a => a.Uid == loginName || a.Phone == loginName);
            }).WithMessage("用户不存在！");
            RuleFor(x => new { x.Old, x.LoginName }).MustAsync(async (obj, collback) => {
                return await _IMemberInfoRepository.IsExistAsync(a => (a.Uid == obj.LoginName || a.Phone == obj.LoginName) && a.Password == Tools.Md5(obj.Old));
            }).WithMessage("原始密码有误！");
            RuleFor(x => x.New).NotEmpty().WithMessage("新密码不能为空！").Matches(@"^(?!(?:[^a-zA-Z]+|\D+|[a-zA-Z0-9]+)$).{6,50}$").WithMessage("新密码必须包含字母、数字和特殊字符");
            RuleFor(x => x.Affirm).NotEmpty().WithMessage("确认密码不能为空！").Must(ReEqualsNew).WithMessage("确认密码必须跟新密码一样！");
        }

        /// <summary>
        /// 判断新密码与重复密码是否一样
        /// </summary>
        /// <param name="model"></param>
        /// <param name="newPwdRe"></param>
        /// <returns></returns>
        private bool ReEqualsNew(PasswordPost model, string newPwdRe) {
            return model.New == newPwdRe;
        }
    }
}
