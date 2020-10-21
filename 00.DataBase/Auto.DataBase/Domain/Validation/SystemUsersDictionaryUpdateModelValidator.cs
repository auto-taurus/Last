using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class SystemUsersDictionaryUpdateModelValidator
        : AbstractValidator<SystemUsersDictionaryUpdateModel>
    {
        public SystemUsersDictionaryUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.DictionaryKey).MaximumLength(20);
            RuleFor(p => p.DictionaryValue).MaximumLength(100);
            #endregion
        }

    }
}
