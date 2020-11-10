using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Applications.Modals {
    public class TaskItem {
        /// <summary>
        /// 会员编号
        /// </summary>
        public int? MemberId { get; set; }
        //[BindNever]
        //public string TaskCode { get; set; }
        /// <summary>
        /// 被邀请人
        /// </summary>
        public int InvitedId { get; set; }
        /// <summary>
        /// 内容标识
        /// </summary>
        public string FromId { get; set; }
        /// <summary>
        /// 来源标识
        /// </summary>
        public int? FromMark { get; set; }
    }
}
