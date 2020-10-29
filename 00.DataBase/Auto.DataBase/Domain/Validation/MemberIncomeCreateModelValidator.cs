using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
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
            RuleFor(p => p.Remarks).MaximumLength(255);
            RuleFor(p => p.Audit).MaximumLength(50);
            #endregion
        }

    }
}
