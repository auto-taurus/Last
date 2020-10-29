using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberFollowCreateModelValidator
        : AbstractValidator<MemberFollowCreateModel>
    {
        public MemberFollowCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SourceTable).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
