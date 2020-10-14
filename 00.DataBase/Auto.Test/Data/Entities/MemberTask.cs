using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class MemberTask
    {
        public MemberTask()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public string Desc { get; set; }

        public int? Category { get; set; }

        public int? IncomeDaily { get; set; }

        public string Platform { get; set; }

        public string Remarks { get; set; }

        public int? IsEnable { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
