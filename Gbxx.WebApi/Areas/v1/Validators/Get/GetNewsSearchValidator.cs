using FluentValidation;
using Gbxx.WebApi.Areas.v1.Models.Get;
using Gbxx.WebApi.Requests.Validators;

namespace Gbxx.WebApi.Areas.v1.Validators.Get {
    public class GetNewsSearchValidator : AbstractValidator<GetNewsSearch> {
        public GetNewsSearchValidator() {
            RuleFor(x => x.Title)
                .NotNull()
                .WithMessage("请传递搜索关键字！")
                .DependentRules(()=> new GetPagerValidator());
        }
    }
}
