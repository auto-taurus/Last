using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class ReportCategoryDayClickReadModel
    {
        #region Generated Properties
        public int CategoryClickId { get; set; }

        public int? CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int? Count { get; set; }

        public DateTime? Today { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        #endregion

    }
}
