using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class ReportSiteDayAccessReadModel
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
