﻿using FluentValidation;

namespace Gbxx.WebApi.Models.Post {
    public class RegisterPost {
        /// <summary>
        /// 微信uid(同一用户不同应用唯一)
        /// </summary>
        public string uid { get; set; }
        /// <summary>
        /// 微信openid(同一用户同一应用唯一)
        /// </summary>
        public string openid { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string gender { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string iconurl { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 注册类型
        /// </summary>
        public int type { get; set; } = 0;
    }
    /// <summary>
    /// 
    /// </summary>
    public class RegisterPostValidator : AbstractValidator<RegisterPost> {
        /// <summary>
        /// 自动验证
        /// </summary>
        public RegisterPostValidator() {
            When(x => x.type == (int)RegisterType.wechat, () => {
                RuleFor(a => a.uid).NotEmpty().WithMessage("请传递uid！");
                RuleFor(a => a.openid).NotEmpty().WithMessage("请传递openid！");
            }).Otherwise(() => {
                RuleFor(a => a.phone).NotEmpty().WithMessage("请传递手机号！").
                Matches(@"0?(13|14|15|17|18|19)[0-9]{9}").WithMessage("手机号格式不正确"); ;
            });
        }
    }

    public enum RegisterType {
        wechat = 0,//微信 默认
        phone = 1//手机号
    }
}
