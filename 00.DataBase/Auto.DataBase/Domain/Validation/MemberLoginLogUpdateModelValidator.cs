using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberLoginLogUpdateModelValidator
        : AbstractValidator<MemberLoginLogUpdateModel>
    {
        public MemberLoginLogUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Source).MaximumLength(10);
            RuleFor(p => p.Column3).MaximumLength(10);
            RuleFor(p => p.Column4).MaximumLength(10);
            #endregion
        }

    }
}
