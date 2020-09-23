using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class SystemRoleDictionaryCreateModelValidator
        : AbstractValidator<SystemRoleDictionaryCreateModel>
    {
        public SystemRoleDictionaryCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.DictionaryKey).MaximumLength(20);
            RuleFor(p => p.DictionaryValue).MaximumLength(100);
            #endregion
        }

    }
}
