using System;
using FluentValidation;
using Master.Domain.Models;

namespace Master.Domain.Validation
{
    public partial class TaskInfoUpdateModelValidator
        : AbstractValidator<TaskInfoUpdateModel>
    {
        public TaskInfoUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TaskCode).MaximumLength(5);
            RuleFor(p => p.RelatedTasks).MaximumLength(50);
            RuleFor(p => p.TaskName).MaximumLength(20);
            RuleFor(p => p.Desc).MaximumLength(50);
            RuleFor(p => p.SaveDesc).MaximumLength(100);
            RuleFor(p => p.Platform).MaximumLength(50);
            RuleFor(p => p.BeansText).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
