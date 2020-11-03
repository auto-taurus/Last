using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class TaskInfoCreateModelValidator
        : AbstractValidator<TaskInfoCreateModel>
    {
        public TaskInfoCreateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.TaskCode).MaximumLength(5);
            RuleFor(p => p.RelatedTasks).MaximumLength(50);
            RuleFor(p => p.TaskName).MaximumLength(20);
            RuleFor(p => p.Desc).MaximumLength(50);
            RuleFor(p => p.Tips).MaximumLength(50);
            RuleFor(p => p.SaveDesc).MaximumLength(100);
            RuleFor(p => p.Platform).MaximumLength(10);
            RuleFor(p => p.BeansText).MaximumLength(20);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
