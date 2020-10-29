using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class SystemUsersCreateModelValidator
        : AbstractValidator<SystemUsersCreateModel>
    {
        public SystemUsersCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.UsersName).MaximumLength(20);
            RuleFor(p => p.LoginName).MaximumLength(50);
            RuleFor(p => p.Password).MaximumLength(50);
            RuleFor(p => p.MobilePhone).MaximumLength(50);
            RuleFor(p => p.Email).MaximumLength(50);
            RuleFor(p => p.LoginIp).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
