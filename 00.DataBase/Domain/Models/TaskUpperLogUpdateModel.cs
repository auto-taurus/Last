using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class TaskUpperLogUpdateModel
    {
        #region Generated Properties
        public int UpperLogId { get; set; }

        public int? TaskId { get; set; }

        public int? MemberId { get; set; }

        public string NewsId { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
