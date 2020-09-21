using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
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
