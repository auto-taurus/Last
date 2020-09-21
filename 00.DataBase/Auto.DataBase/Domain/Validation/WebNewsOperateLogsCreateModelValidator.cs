using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class WebNewsOperateLogsCreateModelValidator
        : AbstractValidator<WebNewsOperateLogsCreateModel>
    {
        public WebNewsOperateLogsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.OperateType).MaximumLength(20);
            RuleFor(p => p.OperateStatus).MaximumLength(255);
            RuleFor(p => p.Remarks).MaximumLength(255);
            RuleFor(p => p.CreateName).MaximumLength(20);
            #endregion
        }

    }
}
