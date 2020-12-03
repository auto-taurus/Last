using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
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
