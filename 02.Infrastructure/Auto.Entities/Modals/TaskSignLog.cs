using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Entities.Modals {
    public partial class TaskSignLog {
        public TaskSignLog() {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int SignLogId { get; set; }

        public int? TaskId { get; set; }

        public int? MemberId { get; set; }

        public int? SignNumber { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        public virtual TaskInfo TaskInfo { get; set; }

        #endregion

    }
}
