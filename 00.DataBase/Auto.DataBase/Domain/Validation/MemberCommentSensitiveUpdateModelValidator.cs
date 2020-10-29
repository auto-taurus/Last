using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberCommentSensitiveUpdateModelValidator
        : AbstractValidator<MemberCommentSensitiveUpdateModel>
    {
        public MemberCommentSensitiveUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SensitiveWords).MaximumLength(20);
            RuleFor(p => p.ReplaceValue).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
