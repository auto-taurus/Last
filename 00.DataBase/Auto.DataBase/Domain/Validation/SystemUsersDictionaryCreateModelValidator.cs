using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class SystemUsersDictionaryCreateModelValidator
        : AbstractValidator<SystemUsersDictionaryCreateModel>
    {
        public SystemUsersDictionaryCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.DictionaryKey).MaximumLength(20);
            RuleFor(p => p.DictionaryValue).MaximumLength(100);
            #endregion
        }

    }
}
