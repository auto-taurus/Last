using FluentValidation;
using Gbxx.WebApi.Models;

namespace Gbxx.WebApi.Requests.Query {
    /// <summary>
    /// 新闻标题检索
    /// </summary>
    public class NewsTitleSearchGet : PagerElastic {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 展示内容类型 （1）
        /// </summary>
        public int ShowType { get; set; }

    }
    /// <summary>
    /// 
    /// </summary>
    public class NewsTitleSearchGetValidator : AbstractValidator<NewsTitleSearchGet> {
        /// <summary>
        /// 
        /// </summary>
        public NewsTitleSearchGetValidator() {
            RuleFor(a => a.Title).NotEmpty().WithMessage("请传搜索关键字！");
            RuleFor(a => a.PageSize).GreaterThan(0).WithMessage("页大小需大于0！")
                                    .NotEmpty().WithMessage("请传递页大小！");
        }
    }
}
