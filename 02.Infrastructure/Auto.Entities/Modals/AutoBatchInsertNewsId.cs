using Auto.Commons.EfCore;
using System;
using System.Collections.Generic;

namespace Auto.Entities.Modals
{
    public partial class AutoBatchInsertNewsId
        : IEntity
    {
        public AutoBatchInsertNewsId()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int? NewsId { get; set; }

        public string Message { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
