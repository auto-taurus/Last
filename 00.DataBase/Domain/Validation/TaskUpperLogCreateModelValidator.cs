using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class TaskUpperLogCreateModelValidator
        : AbstractValidator<TaskUpperLogCreateModel>
    {
        public TaskUpperLogCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.NewsId).MaximumLength(12);
            #endregion
        }

    }
}
