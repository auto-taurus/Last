using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Post {
    public class CommentPost {

        public int? ParentId { get; set; }

        public int? MemberId { get; set; }

        public string MemberName { get; set; }

        public string CommentBody { get; set; }

        public int? QuoteId { get; set; }

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
