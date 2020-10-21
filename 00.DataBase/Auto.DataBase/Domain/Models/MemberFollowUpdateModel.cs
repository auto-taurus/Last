using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class MemberFollowUpdateModel
    {
        #region Generated Properties
        public int FollowId { get; set; }

        public int? MemberId { get; set; }

        public int? SourceId { get; set; }

        public string SourceTable { get; set; }

        public DateTime? FollowTime { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
