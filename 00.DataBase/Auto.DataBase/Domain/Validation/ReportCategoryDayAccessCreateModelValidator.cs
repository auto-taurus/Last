using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
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
