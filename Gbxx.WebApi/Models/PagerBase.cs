using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Models {
    public class PagerBase {
        public PagerBase() {
            this.PageSize = 10;
        }
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }

    }
    /// <summary>
    /// 
    /// </summary>
    public class PagerBaseValidator : AbstractValidator<PagerBase> {
        /// <summary>
        /// 
        /// </summary>
        public PagerBaseValidator() {
            RuleFor(a => a.PageIndex).GreaterThanOrEqualTo(0).WithMessage("当前页需大于等于0！")
                                    .NotEmpty().WithMessage("请传当前页！");
            RuleFor(a => a.PageSize).GreaterThan(0).WithMessage("页大小需大于0！")
                                    .NotEmpty().WithMessage("请传递页大小！");
        }
    }
}
