using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class WebSensitiveUpdateModelValidator
        : AbstractValidator<WebSensitiveUpdateModel>
    {
        public WebSensitiveUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TypeText).MaximumLength(20);
            RuleFor(p => p.SensitiveWords).MaximumLength(50);
            RuleFor(p => p.Author).MaximumLength(1000);
            RuleFor(p => p.Urls).MaximumLength(4000);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
