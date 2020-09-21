using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class ReportCategoryDayClickUpdateModelValidator
        : AbstractValidator<ReportCategoryDayClickUpdateModel>
    {
        public ReportCategoryDayClickUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CategoryName).MaximumLength(50);
            #endregion
        }

    }
}
