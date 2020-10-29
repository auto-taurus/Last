using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class WebNewsSensitiveCreateModelValidator
        : AbstractValidator<WebNewsSensitiveCreateModel>
    {
        public WebNewsSensitiveCreateModelValidator()
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
