using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberCommentUpdateModelValidator
        : AbstractValidator<MemberCommentUpdateModel>
    {
        public MemberCommentUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NewsId).MaximumLength(12);
            RuleFor(p => p.MemberName).MaximumLength(20);
            RuleFor(p => p.CommentBody).MaximumLength(255);
            RuleFor(p => p.QuoteName).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
