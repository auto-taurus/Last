using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberWithdrawConfigCreateModelValidator
        : AbstractValidator<MemberWithdrawConfigCreateModel>
    {
        public MemberWithdrawConfigCreateModelValidator()
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
