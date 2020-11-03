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
            RuleFor(p => p.TaskName).MaximumLength(20);
            RuleFor(p => p.Title).MaximumLength(100);
            RuleFor(p => p.BeansText).MaximumLength(20);
            RuleFor(p => p.Proportion).MaximumLength(20);
            RuleFor(p => p.AuditName).MaximumLength(50);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
