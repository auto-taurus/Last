using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class WebSpecialReadModel
    {
        #region Generated Properties
        public int SpecialId { get; set; }

        public int? SiteId { get; set; }

        public string SpecialCode { get; set; }

        public string Name { get; set; }

        public int? DisplayType { get; set; }

        public int? IsEnable { get; set; }

        public Byte[] RowVers { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
