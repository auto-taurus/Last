using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class SystemMenuUpdateModelValidator
        : AbstractValidator<SystemMenuUpdateModel>
    {
        public SystemMenuUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.MenuIcon).MaximumLength(30);
            RuleFor(p => p.MenuName).MaximumLength(20);
            RuleFor(p => p.NodeValue).MaximumLength(1000);
            RuleFor(p => p.Areas).MaximumLength(100);
            RuleFor(p => p.Controller).MaximumLength(100);
            RuleFor(p => p.Action).MaximumLength(100);
            RuleFor(p => p.Urls).MaximumLength(500);
            RuleFor(p => p.RouterName).MaximumLength(50);
            RuleFor(p => p.RouterPath).MaximumLength(100);
            RuleFor(p => p.Component).MaximumLength(100);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
