using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberIncomeCreateModelValidator
        : AbstractValidator<MemberIncomeCreateModel>
    {
        public MemberIncomeCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TaskCode).MaximumLength(5);
            RuleFor(p => p.TaksName).MaximumLength(20);
            RuleFor(p => p.Title).MaximumLength(100);
            RuleFor(p => p.BeansText).MaximumLength(20);
            RuleFor(p => p.Proportion).MaximumLength(20);
            RuleFor(p => p.AuditName).MaximumLength(50);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
