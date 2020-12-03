using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class AppInfoUpdateModelValidator
        : AbstractValidator<AppInfoUpdateModel>
    {
        public AppInfoUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Code).MaximumLength(10);
            RuleFor(p => p.LogoUrl).MaximumLength(255);
            RuleFor(p => p.PackageName).MaximumLength(50);
            RuleFor(p => p.AppName).MaximumLength(50);
            RuleFor(p => p.Version).NotEmpty();
            RuleFor(p => p.Version).MaximumLength(50);
            RuleFor(p => p.AppUrl).NotEmpty();
            RuleFor(p => p.AppUrl).MaximumLength(255);
            RuleFor(p => p.Introduction).MaximumLength(500);
            RuleFor(p => p.UpdateLog).MaximumLength(500);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
