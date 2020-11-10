using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class WebCategoryUpdateModelValidator
        : AbstractValidator<WebCategoryUpdateModel>
    {
        public WebCategoryUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.CategoryName).MaximumLength(20);
            RuleFor(p => p.NodeValue).MaximumLength(1000);
            RuleFor(p => p.Controller).MaximumLength(50);
            RuleFor(p => p.Action).MaximumLength(50);
            RuleFor(p => p.Urls).MaximumLength(500);
            RuleFor(p => p.Title).MaximumLength(255);
            RuleFor(p => p.Keywords).MaximumLength(255);
            RuleFor(p => p.Description).MaximumLength(255);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
