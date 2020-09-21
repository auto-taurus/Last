using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class ReportCategoryDayAccessCreateModelValidator
        : AbstractValidator<ReportCategoryDayAccessCreateModel>
    {
        public ReportCategoryDayAccessCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CategoryName).MaximumLength(50);
            #endregion
        }

    }
}
