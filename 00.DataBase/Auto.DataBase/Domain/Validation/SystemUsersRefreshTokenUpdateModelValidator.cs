using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
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
