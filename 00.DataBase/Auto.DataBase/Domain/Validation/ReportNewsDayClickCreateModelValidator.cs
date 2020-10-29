using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class ReportNewsDayClickCreateModelValidator
        : AbstractValidator<ReportNewsDayClickCreateModel>
    {
        public ReportNewsDayClickCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CategoryName).MaximumLength(50);
            RuleFor(p => p.SpecialName).MaximumLength(50);
            #endregion
        }

    }
}
