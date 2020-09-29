using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models {
    /// <summary>
    /// 分页查询
    /// </summary>
    public class PageItem : IPageItem {
        /// <summary>
        /// 查询分页
        /// </summary>
        public PageItem() {
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
    public class PageItemValidator : AbstractValidator<PageItem> {
        /// <summary>
        /// 
        /// </summary>
        public PageItemValidator() {
            RuleFor(a => a.PageSize).NotNull().WithMessage("请传递页大小！");
        }
    }
}
