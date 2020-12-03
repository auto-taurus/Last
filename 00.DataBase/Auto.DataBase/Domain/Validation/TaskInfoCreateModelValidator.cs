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
            RuleFor(p => p.ShowDesc).MaximumLength(50);
            RuleFor(p => p.BeansText).MaximumLength(20);
            RuleFor(p => p.Tips).MaximumLength(50);
            RuleFor(p => p.JumpTitle).MaximumLength(100);
            RuleFor(p => p.JumpUrl).MaximumLength(255);
            RuleFor(p => p.Platform).MaximumLength(10);
            RuleFor(p => p.MaxBeansDesc).MaximumLength(100);
            RuleFor(p => p.UpperSecondsDesc).MaximumLength(100);
            RuleFor(p => p.UpperBeansDesc).MaximumLength(100);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
