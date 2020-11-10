using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class TaskSignLogCreateModel
    {
        #region Generated Properties
        public int SignLogId { get; set; }

        public int? TaskId { get; set; }

        public int? MemberId { get; set; }

        public int? SignNumber { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
