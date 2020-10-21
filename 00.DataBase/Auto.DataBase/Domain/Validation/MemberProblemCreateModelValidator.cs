using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberProblemCreateModelValidator
        : AbstractValidator<MemberProblemCreateModel>
    {
        public MemberProblemCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).MaximumLength(50);
            RuleFor(p => p.Desc).MaximumLength(255);
            RuleFor(p => p.Urls).MaximumLength(255);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
