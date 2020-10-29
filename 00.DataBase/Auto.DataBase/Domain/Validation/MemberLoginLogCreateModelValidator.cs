using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberLoginLogCreateModelValidator
        : AbstractValidator<MemberLoginLogCreateModel>
    {
        public MemberLoginLogCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Source).MaximumLength(10);
            RuleFor(p => p.Column3).MaximumLength(10);
            RuleFor(p => p.Column4).MaximumLength(10);
            #endregion
        }

    }
}
