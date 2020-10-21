using Auto.Commons.EfCore;
using System;
using System.Collections.Generic;

namespace Auto.Entities.Modals
{
    public partial class ReportSiteDayAccess
        : IEntity {
        public ReportSiteDayAccess()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int SiteAccessId { get; set; }

        public string SiteId { get; set; }

        public int? Count { get; set; }

        public DateTime? Today { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
