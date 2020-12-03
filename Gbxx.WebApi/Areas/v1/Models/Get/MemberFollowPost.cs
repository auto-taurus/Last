using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Get {
    public class MemberFollowPost {
        /// <summary>
        /// 分类编号
        /// </summary>
        /// <example></example>
        public int CategoryId { get; set; }

        /// <summary>
        /// 来源编号
        /// </summary>
        /// <example></example>
        public int SourceId { get; set; }

        /// <summary>
        ///  关注（默认0, 0关注，1取消关注）
        /// </summary>
        /// <example>0</example>
        public int OType { get; set; }
    }

    /// <summary>
    /// 自动验证
    /// </summary>
    public class MemberFollowPostValidator : AbstractValidator<MemberFollowPost> {
        /// <summary>
        /// 
        /// </summary>
        public MemberFollowPostValidator() {
            RuleFor(a => a.SourceId).GreaterThan(0).WithMessage("请传递关注编号！");
            RuleFor(a => a.OType).GreaterThan(0).WithMessage("请传递操作类型！");
        }
    }
}
