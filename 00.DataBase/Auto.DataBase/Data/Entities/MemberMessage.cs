using System;
using System.Collections.Generic;

namespace Master.Data.Entities
{
    public partial class MemberMessage
    {
        public MemberMessage()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int MessageId { get; set; }

        public int? MemberId { get; set; }

        public string MemberName { get; set; }

        public string LeaveBody { get; set; }

        public int? LeaveType { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

        #region Generated Relationships
        public virtual MemberInfos MemberInfos { get; set; }

        #endregion

    }
}
