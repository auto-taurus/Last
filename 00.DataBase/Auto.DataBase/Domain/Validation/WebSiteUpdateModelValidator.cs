using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class WebSiteUpdateModelValidator
        : AbstractValidator<WebSiteUpdateModel>
    {
        public WebSiteUpdateModelValidator()
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
