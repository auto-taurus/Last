using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class SystemRoleUpdateModelValidator
        : AbstractValidator<SystemRoleUpdateModel>
    {
        public SystemRoleUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.RoleName).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
