using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class TaskDetailsCreateModelValidator
        : AbstractValidator<TaskDetailsCreateModel>
    {
        public TaskDetailsCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.ShowDesc).MaximumLength(50);
            RuleFor(p => p.SaveDesc).MaximumLength(100);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
