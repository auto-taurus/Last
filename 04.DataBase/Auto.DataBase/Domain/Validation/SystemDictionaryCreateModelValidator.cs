using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class SystemDictionaryCreateModelValidator
        : AbstractValidator<SystemDictionaryCreateModel>
    {
        public SystemDictionaryCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Keys).MaximumLength(50);
            RuleFor(p => p.Name).MaximumLength(255);
            RuleFor(p => p.Value).MaximumLength(1000);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
