using FluentValidation;
using System;

namespace Gbxx.WebApi.Areas.v1.Models {
    /// <summary>
    /// ES分页查询
    /// </summary>
    public class ElasticPage {
        /// <summary>
        /// 查询分页
        /// </summary>
        public ElasticPage() {
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
    public class ElasticPageValidator : AbstractValidator<ElasticPage> {
        /// <summary>
        /// 
        /// </summary>
        public ElasticPageValidator() {
            RuleFor(a => a.PageSize).NotNull().WithMessage("请传递页大小！");
        }
    }
}
