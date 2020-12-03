using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class TaskDetailsUpdateModel
    {
        #region Generated Properties
        public int TaskDetailsId { get; set; }

        public int? TaskId { get; set; }

        public string ShowDesc { get; set; }

        public int? Beans { get; set; }

        public int? ExtraBeans { get; set; }

        public string SaveDesc { get; set; }

        public int? Sequence { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
