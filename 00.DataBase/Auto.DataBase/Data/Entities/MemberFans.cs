using System;
using System.Collections.Generic;

namespace Master.Data.Entities
{
    public partial class MemberFans
    {
        public MemberFans()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int FansId { get; set; }

        public int? MemberId { get; set; }

        public int? MemberFansId { get; set; }

        public string MemberFansName { get; set; }

        public DateTime? FollowTime { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

        #region Generated Relationships
        public virtual MemberInfos MemberInfos { get; set; }

        #endregion

    }
}
