using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class ReportCategoryDayAccessUpdateModelValidator
        : AbstractValidator<ReportCategoryDayAccessUpdateModel>
    {
        public ReportCategoryDayAccessUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CategoryName).MaximumLength(50);
            #endregion
        }

    }
}
