using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class MemberFansUpdateModel
    {
        #region Generated Properties
        public int FansId { get; set; }

        public int? MemberId { get; set; }

        public int? MemberFansId { get; set; }

        public string MemberFansName { get; set; }

        public DateTime? FollowTime { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
