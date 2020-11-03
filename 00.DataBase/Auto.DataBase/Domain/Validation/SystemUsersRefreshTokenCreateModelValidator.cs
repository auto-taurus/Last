using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
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
