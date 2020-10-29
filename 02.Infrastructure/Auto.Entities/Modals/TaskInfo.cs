﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Entities.Modals {
    public partial class TaskInfo {

        public TaskInfo() {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int TaskId { get; set; }

        public string TaskCode { get; set; }

        public string RelatedTasks { get; set; }

        public string TaskName { get; set; }

        public string Desc { get; set; }

        public string SaveDesc { get; set; }

        public int? CategoryDay { get; set; }

        public int? CategoryFixed { get; set; }

        public string Platform { get; set; }

        public long? Beans { get; set; }

        public string BeansText { get; set; }

        public int? IsDisplay { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
