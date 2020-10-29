using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class WebSourceCreateModelValidator
        : AbstractValidator<WebSourceCreateModel>
    {
        public WebSourceCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SourceName).MaximumLength(20);
            RuleFor(p => p.SourceLogo).MaximumLength(255);
            #endregion
        }

    }
}
