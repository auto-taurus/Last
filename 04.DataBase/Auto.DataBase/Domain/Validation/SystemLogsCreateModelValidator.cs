using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class SystemLogsCreateModelValidator
        : AbstractValidator<SystemLogsCreateModel>
    {
        public SystemLogsCreateModelValidator()
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
