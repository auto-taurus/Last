using System;
using System.Collections.Generic;

namespace Master.Data.Entities
{
    public partial class MemberFollow
    {
        public MemberFollow()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int FollowId { get; set; }

        public int? MemberId { get; set; }

        public int? SourceId { get; set; }

        public string SourceTable { get; set; }

        public int? CategoryId { get; set; }

        public DateTime? FollowTime { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

        #region Generated Relationships
        public virtual MemberInfos MemberInfos { get; set; }

        #endregion

    }
}
