using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class WebNewsSensitiveReadModel
    {
        #region Generated Properties
        public int NewsSensitiveId { get; set; }

        public int? SiteMark { get; set; }

        public int? NewId { get; set; }

        public string NewTitleRecords { get; set; }

        public string CustomTitleRecords { get; set; }

        public string ContentsRecords { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
