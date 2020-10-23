using FluentValidation;

namespace Gbxx.WebApi.Models.Post {
    public class RegisterPost {
        /// <summary>
        /// 
        /// </summary>
        public string uid { get; set; }
        /// <summary>
        /// 
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
    }
    /// <summary>
    /// 
    /// </summary>
    public class RegisterPostValidator : AbstractValidator<RegisterPost> {
        /// <summary>
        /// 
        /// </summary>
        public RegisterPostValidator() {
            RuleFor(a => a.uid).NotNull().WithMessage("请传递uid！");
            RuleFor(a => a.openid).NotNull().WithMessage("请传递openid！");
        }

    }
}
