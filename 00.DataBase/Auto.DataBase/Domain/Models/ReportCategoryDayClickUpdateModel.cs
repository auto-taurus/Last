using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class ReportCategoryDayClickUpdateModel
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
