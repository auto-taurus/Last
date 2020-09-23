using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class WebNewsCreateModelValidator
        : AbstractValidator<WebNewsCreateModel>
    {
        public WebNewsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.SpecialCode).MaximumLength(10);
            RuleFor(p => p.CategoryName).MaximumLength(50);
            RuleFor(p => p.NewsTitle).MaximumLength(500);
            RuleFor(p => p.CustomTitle).MaximumLength(500);
            RuleFor(p => p.Source).MaximumLength(50);
            RuleFor(p => p.SourceAddress).MaximumLength(1000);
            RuleFor(p => p.SourceLogo).MaximumLength(1000);
            RuleFor(p => p.Tags).MaximumLength(255);
            RuleFor(p => p.Controller).MaximumLength(50);
            RuleFor(p => p.Action).MaximumLength(50);
            RuleFor(p => p.Urls).MaximumLength(1000);
            RuleFor(p => p.ImageThums).MaximumLength(2000);
            RuleFor(p => p.ImagePaths).MaximumLength(2000);
            RuleFor(p => p.Title).MaximumLength(255);
            RuleFor(p => p.Keywords).MaximumLength(255);
            RuleFor(p => p.Description).MaximumLength(255);
            RuleFor(p => p.AuditName).MaximumLength(50);
            RuleFor(p => p.PushName).MaximumLength(50);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
