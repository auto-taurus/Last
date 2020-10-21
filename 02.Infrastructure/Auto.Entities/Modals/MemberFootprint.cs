using System;
using System.Collections.Generic;

namespace Auto.Entities.Modals
{
    public partial class MemberFootprint
    {
        public MemberFootprint()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int FootprintId { get; set; }

        public int? MemberId { get; set; }

        public string SourceId { get; set; }

        public string SourceTable { get; set; }

        public DateTime? BrowseTime { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

        #region Generated Relationships
        public virtual MemberInfos MemberInfos { get; set; }

        #endregion

    }
}
