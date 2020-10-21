using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberCommentCreateModelValidator
        : AbstractValidator<MemberCommentCreateModel>
    {
        public MemberCommentCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NewsId).MaximumLength(12);
            RuleFor(p => p.OCommentName).MaximumLength(20);
            RuleFor(p => p.OCommentBody).MaximumLength(255);
            RuleFor(p => p.TCommentName).MaximumLength(20);
            RuleFor(p => p.TCommentBody).MaximumLength(255);
            RuleFor(p => p.QuoteName).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
