using FluentValidation;

namespace Gbxx.WebApi.Areas.v1.Models.Route {
    /// <summary>
    /// 新闻资讯路由参数
    /// </summary>
    public class SiteIdRoute: SiteRoute {
        /// <summary>
        /// 主要信息编号，专栏code等
        /// </summary>
        public string id { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class WebRouteValidator : AbstractValidator<SiteIdRoute> {
        /// <summary>
        /// 
        /// </summary>
        public WebRouteValidator() {
            RuleFor(a => a.mark).NotNull().WithMessage("请传递站点标识！");
            RuleFor(a => a.id).NotNull().WithMessage("请传递数据唯一标识！");
        }
    }
}
