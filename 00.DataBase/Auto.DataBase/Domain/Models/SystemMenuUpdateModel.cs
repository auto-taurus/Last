using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class SystemMenuUpdateModel
    {
        #region Generated Properties
        public int MenuId { get; set; }

        public int? SiteId { get; set; }

        public string MenuIcon { get; set; }

        public string MenuName { get; set; }

        public int? ParentId { get; set; }

        public string NodeValue { get; set; }

        public string Areas { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string Urls { get; set; }

        public string RouterName { get; set; }

        public string RouterPath { get; set; }

        public string Component { get; set; }

        public int? ShowAlways { get; set; }

        public int? ShowHeader { get; set; }

        public int? HideInBread { get; set; }

        public int? HideInMenu { get; set; }

        public int? NotCache { get; set; }

        public int? BeforeCloseName { get; set; }

        public int? Sequence { get; set; }

        public int? IsEnable { get; set; }

        public Byte[] RowVers { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
