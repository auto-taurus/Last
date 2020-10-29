using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class SystemUsersRefreshTokenCreateModelValidator
        : AbstractValidator<SystemUsersRefreshTokenCreateModel>
    {
        public SystemUsersRefreshTokenCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.AccessToken).MaximumLength(1000);
            #endregion
        }

    }
}
