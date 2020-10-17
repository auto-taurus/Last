using FluentValidation;

namespace Gbxx.WebApi.Areas.v1.Models.Route {
    /// <summary>
    /// 
    /// </summary>
    public class IdRoute {
        /// <summary>
        /// 主要信息唯一标识
        /// </summary>
        public string id { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class IdRouteValidator : AbstractValidator<IdRoute> {
        /// <summary>
        /// 
        /// </summary>
        public IdRouteValidator() {
            RuleFor(a => a.id).NotNull().WithMessage("请传递数据唯一标识！");
        }
    }
}
