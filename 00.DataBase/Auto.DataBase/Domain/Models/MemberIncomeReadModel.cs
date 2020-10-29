using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class MemberIncomeReadModel
    {
        #region Generated Properties
        public int IncomeId { get; set; }

        public int? MemberId { get; set; }

        public string TaskCode { get; set; }

        public string TaksName { get; set; }

        public string Title { get; set; }

        public int? Beans { get; set; }

        public string BeansText { get; set; }

        public DateTime? CreateTime { get; set; }

        public string Proportion { get; set; }

        public int? ReadTime { get; set; }

        public int? Status { get; set; }

        public string Remarks { get; set; }

        public int? AuditId { get; set; }

        public string Audit { get; set; }

        public DateTime? AuditTime { get; set; }

        #endregion

    }
}
