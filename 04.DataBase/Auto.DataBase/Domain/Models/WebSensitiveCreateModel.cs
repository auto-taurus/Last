using System;
using System.Collections.Generic;

namespace Company.AutoNews.Domain.Models
{
    public partial class WebSensitiveCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int SensitiveId { get; set; }

        public int? SiteNo { get; set; }

        public int? Type { get; set; }

        public string TypeText { get; set; }

        public string SensitiveWords { get; set; }

        public string Author { get; set; }

        public string Urls { get; set; }

        public Byte[] Timestamp { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
