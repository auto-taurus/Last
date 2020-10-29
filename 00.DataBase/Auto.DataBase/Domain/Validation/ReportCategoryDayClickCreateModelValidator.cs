using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
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
