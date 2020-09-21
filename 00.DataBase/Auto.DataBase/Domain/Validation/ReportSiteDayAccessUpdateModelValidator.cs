using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class ReportSiteDayAccessUpdateModelValidator
        : AbstractValidator<ReportSiteDayAccessUpdateModel>
    {
        public ReportSiteDayAccessUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SiteNo).MaximumLength(10);
            #endregion
        }

    }
}
