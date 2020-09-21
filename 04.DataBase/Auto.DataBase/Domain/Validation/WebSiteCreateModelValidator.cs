using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class WebSiteCreateModelValidator
        : AbstractValidator<WebSiteCreateModel>
    {
        public WebSiteCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SiteName).MaximumLength(50);
            RuleFor(p => p.SiteUrls).MaximumLength(255);
            RuleFor(p => p.LogoUrls).MaximumLength(255);
            RuleFor(p => p.Title).MaximumLength(255);
            RuleFor(p => p.Keywords).MaximumLength(255);
            RuleFor(p => p.Description).MaximumLength(255);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
