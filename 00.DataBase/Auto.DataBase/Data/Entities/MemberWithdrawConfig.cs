using System;
using System.Collections.Generic;

namespace Master.Data.Entities
{
    public partial class MemberWithdrawConfig
    {
        public MemberWithdrawConfig()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int WithdrawConfigId { get; set; }

        public int? Methods { get; set; }

        public string Tips { get; set; }

        public string WithdrawTask { get; set; }

        public decimal? Amount { get; set; }

        public string AmountTips { get; set; }

        public string AmountDesc { get; set; }

        public string AmountTask { get; set; }

        public string Desc { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
