using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Route {
    public class SiteRoute {

        /// <summary>
        /// 站点标识
        /// </summary>
        public string mark { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class SiteRouteValidator : AbstractValidator<SiteRoute> {
        /// <summary>
        /// 
        /// </summary>
        public SiteRouteValidator() {
            RuleFor(a => a.mark).NotNull().WithMessage("请传递站点标识！");
        }
    }
}
