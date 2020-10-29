using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class SystemLogsUpdateModelValidator
        : AbstractValidator<SystemLogsUpdateModel>
    {
        public SystemLogsUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Methods).MaximumLength(100);
            RuleFor(p => p.Source).MaximumLength(50);
            RuleFor(p => p.Args).MaximumLength(2000);
            RuleFor(p => p.Errors).MaximumLength(2000);
            #endregion
        }

    }
}
