using System;
using System.Collections.Generic;

namespace Company.AutoNews.Domain.Models
{
    public partial class ReportCategoryDayAccessCreateModel
        : EntityCreateModel
    {
        #region Generated Properties
        public int CategoryAccessId { get; set; }

        public int? CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int? Count { get; set; }

        public DateTime? Today { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        #endregion

    }
}
