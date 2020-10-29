using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
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
