using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberProblemUpdateModelValidator
        : AbstractValidator<MemberProblemUpdateModel>
    {
        public MemberProblemUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(50);
            RuleFor(p => p.Desc).MaximumLength(500);
            RuleFor(p => p.Urls).MaximumLength(500);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
