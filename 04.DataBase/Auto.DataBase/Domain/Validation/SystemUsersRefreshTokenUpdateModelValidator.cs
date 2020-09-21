using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class SystemUsersRefreshTokenUpdateModelValidator
        : AbstractValidator<SystemUsersRefreshTokenUpdateModel>
    {
        public SystemUsersRefreshTokenUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.AccessToken).MaximumLength(1000);
            #endregion
        }

    }
}
