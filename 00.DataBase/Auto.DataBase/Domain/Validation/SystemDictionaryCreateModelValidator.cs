using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class SystemDictionaryCreateModelValidator
        : AbstractValidator<SystemDictionaryCreateModel>
    {
        public SystemDictionaryCreateModelValidator()
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
