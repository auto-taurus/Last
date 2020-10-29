using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberFansUpdateModelValidator
        : AbstractValidator<MemberFansUpdateModel>
    {
        public MemberFansUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MemberFansName).MaximumLength(50);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
