using System;
using System.Collections.Generic;

namespace Master.Data.Entities
{
    public partial class SystemLogs
    {
        public SystemLogs()
        {
            #region Generated Constructor
            #endregion
        }

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

        #region Generated Relationships
        #endregion

    }
}
