using FluentValidation;
using System;

namespace Gbxx.WebApi.Models {
    /// <summary>
    /// ES分页查询
    /// </summary>
    public class PagerElastic {
        /// <summary>
        /// 查询分页
        /// </summary>
        public PagerElastic() {
            this.PageSize = 10;
        }
        /// <summary>
        /// 当前页
        /// 格式：value,value,value...
        /// </summary>
        public String PageIndex { get; set; }
        /// <summary>
        /// 页大小
        /// </summary>
        public int? PageSize { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ElasticPagerValidator : AbstractValidator<PagerElastic> {
        /// <summary>
        /// 
        /// </summary>
        public ElasticPagerValidator() {
            RuleFor(a => a.PageSize).GreaterThan(0).WithMessage("页大小需大于0！")
                                    .NotEmpty().WithMessage("请传递页大小！");
        }
    }
}
