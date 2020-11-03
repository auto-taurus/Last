using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
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
