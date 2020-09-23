using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class ReportSiteDayAccess
    {
        public ReportSiteDayAccess()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int SiteAccessId { get; set; }

        public string SiteNo { get; set; }

        public int? Count { get; set; }

        public DateTime? Today { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
