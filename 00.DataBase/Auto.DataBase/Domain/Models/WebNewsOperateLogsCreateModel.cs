using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class WebNewsOperateLogsCreateModel
    {
        #region Generated Properties
        public int NewsOperateId { get; set; }

        public string NewsId { get; set; }

        public string OperateType { get; set; }

        public string OperateStatus { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public string CreateName { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
