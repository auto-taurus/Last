using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberCommentCreateModelValidator
        : AbstractValidator<MemberCommentCreateModel>
    {
        public MemberCommentCreateModelValidator()
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
