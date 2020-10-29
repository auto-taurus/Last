using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class WebSpecialUpdateModelValidator
        : AbstractValidator<WebSpecialUpdateModel>
    {
        public WebSpecialUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SpecialCode).MaximumLength(10);
            RuleFor(p => p.Name).MaximumLength(50);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
