using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberFavoritesCreateModelValidator
        : AbstractValidator<MemberFavoritesCreateModel>
    {
        public MemberFavoritesCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SourceId).MaximumLength(20);
            RuleFor(p => p.SourceTable).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
