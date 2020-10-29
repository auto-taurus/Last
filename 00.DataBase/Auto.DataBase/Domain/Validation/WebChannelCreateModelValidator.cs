using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class WebChannelCreateModelValidator
        : AbstractValidator<WebChannelCreateModel>
    {
        public WebChannelCreateModelValidator()
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
