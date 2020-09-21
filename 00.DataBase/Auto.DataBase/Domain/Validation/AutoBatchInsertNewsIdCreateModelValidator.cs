using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class AutoBatchInsertNewsIdCreateModelValidator
        : AbstractValidator<AutoBatchInsertNewsIdCreateModel>
    {
        public AutoBatchInsertNewsIdCreateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
