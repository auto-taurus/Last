using System;
using FluentValidation;
using Company.AutoNews.Domain.Models;

namespace Auto.EFCore.Validator
{
    public partial class AutoBatchInsertNewsIdUpdateModelValidator
        : AbstractValidator<AutoBatchInsertNewsIdUpdateModel>
    {
        public AutoBatchInsertNewsIdUpdateModelValidator()
        {
            #region Generated Constructor
            #endregion
        }

    }
}
