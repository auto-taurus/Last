using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Post {
    /// <summary>
    /// 
    /// </summary>
    public class LoginPost {
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 登录方式（0手机登录，1微信登录）
        /// </summary>
        public int? LoginMethods { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>
        public string Wechat { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class LoginPostValidator : AbstractValidator<LoginPost> {
        /// <summary>
        /// 
        /// </summary>
        public LoginPostValidator() {
            RuleFor(a => a.LoginName).NotNull().WithMessage("请输入登录名！");
            RuleFor(a => a.Password).NotNull().WithMessage("请输入用户密码！");
            RuleFor(a => a.LoginName).NotNull().WithMessage("缺少登录方式！");
        }

    }
}
