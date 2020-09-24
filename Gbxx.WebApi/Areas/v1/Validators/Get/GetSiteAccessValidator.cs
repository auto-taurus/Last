using FluentValidation;
using FluentValidation.Results;
using Gbxx.WebApi.Areas.v1.Models.Get;
using Gbxx.WebApi.Requests;
using Gbxx.WebApi.Requests.Validators;
using System.ComponentModel.DataAnnotations;

namespace Gbxx.WebApi.Areas.v1.Validators.Get {
    public class GetSiteAccessValidator : AbstractValidator<GetSiteAccess> {
        public GetSiteAccessValidator() {
            RuleFor(x => x.Referrer).NotNull().WithMessage("请传递来源Referrer！");
            RuleFor(x => x.Unique).NotNull().WithMessage("请传递唯一标识！").Custom((x, context) => {
                if (context.ParentContext.RootContextData.IsReadOnly) {
                    new GetBaseValidator().Validate(new GetPager());
                    var dd = context.ParentContext.RootContextData;

                    //contexkt.AddFailure();
                }
            });
            
        }
    }
}
