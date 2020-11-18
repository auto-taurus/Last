using FluentValidation;

namespace Gbxx.WebApi.Models {
    public class RouteCode {
        public string code { get; set; }
    }
    public class RouteCodeValidator : AbstractValidator<RouteCode> {
        /// <summary>
        /// 校验
        /// </summary>
        public RouteCodeValidator() {
            RuleFor(a => a.code).NotEmpty().WithMessage("code不能为空！");
        }
    }
}
