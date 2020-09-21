using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class ReportCategoryDayClickCreateModelValidator
        : AbstractValidator<ReportCategoryDayClickCreateModel>
    {
        public ReportCategoryDayClickCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CategoryName).MaximumLength(50);
            #endregion
        }

    }
}
