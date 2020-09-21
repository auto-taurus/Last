using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class ReportSiteDayAccessCreateModelValidator
        : AbstractValidator<ReportSiteDayAccessCreateModel>
    {
        public ReportSiteDayAccessCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SiteNo).MaximumLength(10);
            #endregion
        }

    }
}
