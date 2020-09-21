using System;
using System.Collections.Generic;

namespace Company.AutoNews.Domain.Models
{
    public partial class ReportNewsDayAccessCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int NewsAccessId { get; set; }

        public int? NewsId { get; set; }

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
