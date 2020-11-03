using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class WebSiteUpdateModel
    {
        #region Generated Properties
        public int SiteId { get; set; }

        public string SiteName { get; set; }

        public string SiteUrls { get; set; }

        public string LogoUrls { get; set; }

        public int? AccessNumber { get; set; }

        public string Title { get; set; }

        public string Keywords { get; set; }

        public string Description { get; set; }

        public Byte[] RowVers { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
