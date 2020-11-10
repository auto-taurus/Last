using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class WebSourceUpdateModelValidator
        : AbstractValidator<WebSourceUpdateModel>
    {
        public WebSourceUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SourceName).MaximumLength(20);
            RuleFor(p => p.SourceLogo).MaximumLength(255);
            #endregion
        }

    }
}
