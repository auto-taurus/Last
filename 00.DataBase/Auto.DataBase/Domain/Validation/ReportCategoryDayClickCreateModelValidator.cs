using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
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
