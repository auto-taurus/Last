using System;
using System.Collections.Generic;

namespace Company.AutoNews.Domain.Models
{
    public partial class AutoBatchInsertNewsIdReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int Id { get; set; }

        public int? NewsId { get; set; }

        public string Message { get; set; }

        #endregion

    }
}
