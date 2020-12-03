using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class WebSourceReadModel
    {
        #region Generated Properties
        public int SourceId { get; set; }

        public int? CategoryId { get; set; }

        public string SourceName { get; set; }

        public string SourceLogo { get; set; }

        public int? FollowNumber { get; set; }

        public int? Sequence { get; set; }

        public int? IsEnable { get; set; }

        public DateTime? Remarks { get; set; }

        #endregion

    }
}
