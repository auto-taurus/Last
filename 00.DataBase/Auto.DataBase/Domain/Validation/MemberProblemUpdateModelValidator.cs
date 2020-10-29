using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class MemberProblemUpdateModelValidator
        : AbstractValidator<MemberProblemUpdateModel>
    {
        public MemberProblemUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(50);
            RuleFor(p => p.Desc).MaximumLength(255);
            RuleFor(p => p.Urls).MaximumLength(500);
            RuleFor(p => p.Remarks).MaximumLength(500);
            #endregion
        }

    }
}
