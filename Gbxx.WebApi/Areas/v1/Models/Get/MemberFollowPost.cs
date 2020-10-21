using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models.Get {
    public class MemberFollowPost {
        public int CategoryId { get; set; }
        public int SourceId { get; set; }
        /// <summary>
        /// 0关注，1取消关注
        /// </summary>
        public int OType { get; set; }
    }/// <summary>
     /// 
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
