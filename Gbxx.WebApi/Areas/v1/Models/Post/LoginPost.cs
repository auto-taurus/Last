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
        /// 登录名（手机号）
        /// </summary>
        /// <example></example>
        public string LoginName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        /// <example></example>
        public string Password { get; set; }
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
        }

    }
}
