using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class ReportCategoryDayAccess
        : IBaseEntity
    {
        public ReportCategoryDayAccess()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CategoryAccessId { get; set; }

        public int? CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int? Count { get; set; }

        public DateTime? Today { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
