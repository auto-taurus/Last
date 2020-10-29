using System;
using System.Collections.Generic;

namespace Master.Data.Entities
{
    public partial class WebSource
    {
        public WebSource()
        {
            #region Generated Constructor
            WebNews = new HashSet<WebNews>();
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

        public virtual ICollection<WebNews> WebNews { get; set; }

        #endregion

    }
}
