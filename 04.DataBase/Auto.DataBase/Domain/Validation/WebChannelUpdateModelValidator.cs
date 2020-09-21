using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class WebChannelUpdateModelValidator
        : AbstractValidator<WebChannelUpdateModel>
    {
        public WebChannelUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ChannelName).MaximumLength(100);
            RuleFor(p => p.ChannelAddress).MaximumLength(1000);
            RuleFor(p => p.ChannelJs).MaximumLength(255);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
