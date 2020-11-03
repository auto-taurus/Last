using System;
using System.Collections.Generic;

namespace Auto.Entities.Modals {
    public partial class MemberIncome {
        public MemberIncome() {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int IncomeId { get; set; }

        public int? MemberId { get; set; }

        public int? TaskId { get; set; }

        public string TaskCode { get; set; }

        public string TaskName { get; set; }

        public int? CategoryDay { get; set; }

        public int? CategoryFixed { get; set; }

        public string Title { get; set; }

        public int? Beans { get; set; }

        public string BeansText { get; set; }

        public DateTime? CreateTime { get; set; }

        public string Proportion { get; set; }

        public int? Number { get; set; }

        public int? ReadTime { get; set; }

        public int? Status { get; set; }

        public string Remarks { get; set; }

        public int? AuditBy { get; set; }

        public string AuditName { get; set; }

        public DateTime? AuditTime { get; set; }

        #endregion

        #region Generated Relationships
        public virtual MemberInfos MemberInfos { get; set; }
        public virtual TaskInfo TaskInfo { get; set; }

        #endregion
    }
}