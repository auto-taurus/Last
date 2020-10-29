using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberWithdrawConfigUpdateModelValidator
        : AbstractValidator<MemberWithdrawConfigUpdateModel>
    {
        public MemberWithdrawConfigUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Tips).MaximumLength(20);
            RuleFor(p => p.WithdrawTask).MaximumLength(5);
            RuleFor(p => p.AmountTips).MaximumLength(20);
            RuleFor(p => p.AmountDesc).MaximumLength(255);
            RuleFor(p => p.AmountTask).MaximumLength(5);
            RuleFor(p => p.Desc).MaximumLength(255);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
