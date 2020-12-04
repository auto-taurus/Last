using FluentValidation;

namespace Gbxx.WebApi.Areas.v1.Models.Post {
    public class MessagePost {
        /// <summary>
        /// 会员编号，客户编号
        /// </summary>
        /// <example></example>example设置默认值
        public int? MemberId { get; set; }
        /// <summary>
        /// 会员名称，客户名称
        /// </summary>
        /// <example></example>
        public string MemberName { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        /// <example></example>
        public string LeaveBody { get; set; }
        /// <summary>
        /// 0会员留言，1客服回复（默认为0）
        /// </summary>
        /// <example>0</example>
        public int? LeaveType { get; set; } = 0;
    }
    /// <summary>
    /// 
    /// </summary>
    public class MessagePostValidator : AbstractValidator<MessagePost> {
        /// <summary>
        /// 
        /// </summary>
        public MessagePostValidator() {
            RuleFor(a => a.MemberId).NotEmpty().WithMessage("请传递用户编号！");
            RuleFor(a => a.MemberName).NotEmpty().WithMessage("请传递用户名称或昵称！");
            RuleFor(a => a.LeaveBody).NotEmpty().WithMessage("请传递留言内容！");
        }
    }
}
