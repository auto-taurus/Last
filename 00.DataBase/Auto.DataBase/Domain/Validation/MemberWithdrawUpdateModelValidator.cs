using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberWithdrawUpdateModelValidator
        : AbstractValidator<MemberWithdrawUpdateModel>
    {
        public MemberWithdrawUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(50);
            RuleFor(p => p.Proportion).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            RuleFor(p => p.Audit).MaximumLength(50);
            #endregion
        }

    }
}
