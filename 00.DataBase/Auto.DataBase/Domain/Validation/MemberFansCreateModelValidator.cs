using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberFansCreateModelValidator
        : AbstractValidator<MemberFansCreateModel>
    {
        public MemberFansCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MemberFansName).MaximumLength(50);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
