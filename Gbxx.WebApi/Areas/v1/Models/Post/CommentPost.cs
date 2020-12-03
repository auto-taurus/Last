using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Post {
    public class CommentPost {

        /// <summary>
        /// 父级评论编号
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 评论人编号
        /// </summary>
        public int? MemberId { get; set; }

        /// <summary>
        /// 评论人名称（昵称）
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string CommentBody { get; set; }

        /// <summary>
        /// 被引用人编号
        /// </summary>
        public int? QuoteId { get; set; }

        /// <summary>
        /// 被引用人名称（昵称）
        /// </summary>
        public string QuoteName { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class CommentPostValidator : AbstractValidator<CommentPost> {
        /// <summary>
        /// 
        /// </summary>
        public CommentPostValidator() {
            RuleFor(a => a.MemberId).NotEmpty().WithMessage("请传递用户编号！");
            RuleFor(a => a.MemberName).NotEmpty().WithMessage("请传递用户名称或昵称！");
            RuleFor(a => a.CommentBody).NotEmpty().WithMessage("请传递评论内容！");
        }
    }
}
