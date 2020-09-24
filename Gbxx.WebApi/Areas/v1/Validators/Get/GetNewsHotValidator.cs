using FluentValidation;
using Gbxx.WebApi.Areas.v1.Models.Get;

namespace Gbxx.WebApi.Areas.v1.Validators.Get {
    public class GetNewsHotValidator : AbstractValidator<GetNewsHot> {
        public GetNewsHotValidator() {
            RuleFor(x => x.Days).NotNull().WithMessage("请传递天数！");
        }
    }
}
