using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class ReportSiteDayAccessUpdateModel
    {
        #region Generated Properties
        public int SiteAccessId { get; set; }

        public int? SiteId { get; set; }

        public int? Count { get; set; }

        public DateTime? Today { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        #endregion

    }
}
