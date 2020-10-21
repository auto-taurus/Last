using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberFollowUpdateModelValidator
        : AbstractValidator<MemberFollowUpdateModel>
    {
        public MemberFollowUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SourceTable).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
