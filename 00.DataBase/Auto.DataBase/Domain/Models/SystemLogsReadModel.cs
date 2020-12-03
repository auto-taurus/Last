using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class SystemLogsReadModel
    {
        #region Generated Properties
        public int LogsId { get; set; }

        public string Methods { get; set; }

        public int? Grade { get; set; }

        public string Source { get; set; }

        public string Args { get; set; }

        public string Errors { get; set; }

        public int? CreateBy { get; set; }

        public DateTime CreateTime { get; set; }

        #endregion

    }
}
