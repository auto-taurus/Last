using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class SystemRoleUpdateModel
    {
        #region Generated Properties
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
