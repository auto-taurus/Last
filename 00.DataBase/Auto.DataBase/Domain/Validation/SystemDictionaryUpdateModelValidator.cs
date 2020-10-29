using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class SystemDictionaryUpdateModelValidator
        : AbstractValidator<SystemDictionaryUpdateModel>
    {
        public SystemDictionaryUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TypeKey).MaximumLength(20);
            RuleFor(p => p.DistKey).MaximumLength(20);
            RuleFor(p => p.DistName).MaximumLength(20);
            RuleFor(p => p.DistValue).MaximumLength(255);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
