using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class WebSource
    {
        public WebSource()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int SourceId { get; set; }

        public int? CategoryId { get; set; }

        public string SourceName { get; set; }

        public string SourceLogo { get; set; }

        public int? FollowNumber { get; set; }

        public int? Sequence { get; set; }

        public int? IsEnable { get; set; }

        public DateTime? Remarks { get; set; }

        #endregion

        #region Generated Relationships
        public virtual WebCategory WebCategory { get; set; }

        #endregion

    }
}
