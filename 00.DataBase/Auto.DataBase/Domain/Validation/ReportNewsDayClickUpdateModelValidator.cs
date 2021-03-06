using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class ReportNewsDayClickUpdateModelValidator
        : AbstractValidator<ReportNewsDayClickUpdateModel>
    {
        public ReportNewsDayClickUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NewsId).MaximumLength(12);
            RuleFor(p => p.CategoryName).MaximumLength(50);
            RuleFor(p => p.SpecialName).MaximumLength(50);
            #endregion
        }

    }
}
