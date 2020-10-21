using System;
using FluentValidation;
using AutoNews.Domain.Models;

namespace AutoNews.Domain.Validation
{
    public partial class MemberInfosUpdateModelValidator
        : AbstractValidator<MemberInfosUpdateModel>
    {
        public MemberInfosUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Code).MaximumLength(10);
            RuleFor(p => p.NickName).MaximumLength(20);
            RuleFor(p => p.Name).MaximumLength(20);
            RuleFor(p => p.Phone).MaximumLength(15);
            RuleFor(p => p.Alipay).MaximumLength(20);
            RuleFor(p => p.Wechat).MaximumLength(50);
            RuleFor(p => p.Password).MaximumLength(100);
            RuleFor(p => p.Avatar).MaximumLength(255);
            RuleFor(p => p.Remarks).MaximumLength(255);
            #endregion
        }

    }
}
