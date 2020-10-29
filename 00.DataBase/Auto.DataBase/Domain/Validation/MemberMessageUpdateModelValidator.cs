using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberMessageUpdateModelValidator
        : AbstractValidator<MemberMessageUpdateModel>
    {
        public MemberMessageUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MemberName).MaximumLength(20);
            RuleFor(p => p.LeaveBody).MaximumLength(255);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
