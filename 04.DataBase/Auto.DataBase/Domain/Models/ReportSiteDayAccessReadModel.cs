using System;
using System.Collections.Generic;

namespace Company.AutoNews.Domain.Models
{
    public partial class ReportSiteDayAccessReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int SiteAccessId { get; set; }

        public string SiteNo { get; set; }

        public int? Count { get; set; }

        public DateTime? Today { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        #endregion

    }
}
