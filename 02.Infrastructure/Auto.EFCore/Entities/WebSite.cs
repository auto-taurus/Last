using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class WebSite
        : EntityBase
    {
        public WebSite()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int SiteId { get; set; }

        public int? SiteNo { get; set; }

        public string SiteName { get; set; }

        public string SiteUrls { get; set; }

        public string LogoUrls { get; set; }

        public int? Count { get; set; }

        public string Title { get; set; }

        public string Keywords { get; set; }

        public string Description { get; set; }

        public Byte[] RowVers { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
