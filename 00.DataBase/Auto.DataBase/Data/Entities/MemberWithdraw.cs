using System;
using System.Collections.Generic;

namespace Master.Data.Entities
{
    public partial class MemberWithdraw
    {
        public MemberWithdraw()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public long WithdrawId { get; set; }

        public int? MemberId { get; set; }

        public int? Methods { get; set; }

        public string Title { get; set; }

        public int? Beans { get; set; }

        public decimal? Amount { get; set; }

        public string Proportion { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Status { get; set; }

        public string Remarks { get; set; }

        public int? AuditId { get; set; }

        public string Audit { get; set; }

        public DateTime? AuditTime { get; set; }

        #endregion

        #region Generated Relationships
        public virtual MemberInfos MemberInfos { get; set; }

        #endregion

    }
}
