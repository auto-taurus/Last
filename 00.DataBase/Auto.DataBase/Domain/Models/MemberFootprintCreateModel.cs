using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class MemberFootprintCreateModel
    {
        #region Generated Properties
        public int FootprintId { get; set; }

        public int? MemberId { get; set; }

        public string SourceId { get; set; }

        public string SourceTable { get; set; }

        public DateTime? BrowseTime { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
