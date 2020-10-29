using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class MemberFollowReadModel
    {
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

    }
}
