using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberIncomeUpdateModelValidator
        : AbstractValidator<MemberIncomeUpdateModel>
    {
        public MemberIncomeUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TaskCode).MaximumLength(5);
            RuleFor(p => p.TaksName).MaximumLength(20);
            RuleFor(p => p.Title).MaximumLength(100);
            RuleFor(p => p.Proportion).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            RuleFor(p => p.Audit).MaximumLength(50);
            #endregion
        }

    }
}
