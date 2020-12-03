using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class ReportNewsDayClickCreateModel
    {
        #region Generated Properties
        public int NewsClickId { get; set; }

        public string NewsId { get; set; }

        public int? CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int? SpecialCode { get; set; }

        public string SpecialName { get; set; }

        public int? Count { get; set; }

        public DateTime? Today { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        #endregion

    }
}
