using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Entities.Modals {
    public partial class TaskUpperLog {
        public TaskUpperLog() {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int UpperLogId { get; set; }

        public int? TaskId { get; set; }

        public int? MemberId { get; set; }

        public string NewsId { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        public virtual TaskInfo TaskInfo { get; set; }

        #endregion

    }
}
