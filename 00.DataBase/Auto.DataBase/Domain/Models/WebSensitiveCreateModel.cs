using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class WebSensitiveCreateModel
    {
        #region Generated Properties
        public int SensitiveId { get; set; }

        public int? SiteId { get; set; }

        public int? Type { get; set; }

        public string TypeText { get; set; }

        public string SensitiveWords { get; set; }

        public string Author { get; set; }

        public string Urls { get; set; }

        public Byte[] RowVers { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
