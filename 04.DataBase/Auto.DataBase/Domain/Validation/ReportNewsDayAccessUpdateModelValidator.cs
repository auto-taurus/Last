using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class ReportNewsDayAccessUpdateModelValidator
        : AbstractValidator<ReportNewsDayAccessUpdateModel>
    {
        public ReportNewsDayAccessUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CategoryName).MaximumLength(50);
            RuleFor(p => p.SpecialName).MaximumLength(50);
            #endregion
        }

    }
}
