using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberCommentSensitiveCreateModelValidator
        : AbstractValidator<MemberCommentSensitiveCreateModel>
    {
        public MemberCommentSensitiveCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SensitiveWords).MaximumLength(20);
            RuleFor(p => p.ReplaceValue).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
