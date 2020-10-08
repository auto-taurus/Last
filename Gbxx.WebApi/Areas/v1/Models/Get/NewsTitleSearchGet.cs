using FluentValidation;
using Gbxx.WebApi.Areas.v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Requests.Query {
    /// <summary>
    /// 新闻标题检索
    /// </summary>
    public class NewsTitleSearchGet : ElasticPage {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class NewsTitleSearchGetValidator : AbstractValidator<NewsTitleSearchGet> {
        /// <summary>
        /// 
        /// </summary>
        public NewsTitleSearchGetValidator() {
            RuleFor(a => a.Title).Null().WithMessage("请传搜索关键字！");
            RuleFor(a => a.PageIndex).Null().WithMessage("请传递当前页！");
            RuleFor(a => a.PageSize).Null().WithMessage("请传递页大小！");
        }
    }
}
