using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class WebNewsSensitiveUpdateModelValidator
        : AbstractValidator<WebNewsSensitiveUpdateModel>
    {
        public WebNewsSensitiveUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NewTitleRecords).MaximumLength(1000);
            RuleFor(p => p.CustomTitleRecords).MaximumLength(1000);
            RuleFor(p => p.ContentsRecords).MaximumLength(1000);
            RuleFor(p => p.Remarks).MaximumLength(1000);
            #endregion
        }

    }
}
