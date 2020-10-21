using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class WebNewsOperateLogsUpdateModelValidator
        : AbstractValidator<WebNewsOperateLogsUpdateModel>
    {
        public WebNewsOperateLogsUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NewsId).MaximumLength(12);
            RuleFor(p => p.OperateType).MaximumLength(20);
            RuleFor(p => p.OperateStatus).MaximumLength(255);
            RuleFor(p => p.Remarks).MaximumLength(255);
            RuleFor(p => p.CreateName).MaximumLength(20);
            #endregion
        }

    }
}
