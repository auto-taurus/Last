using System;
using System.Collections.Generic;

namespace Company.AutoNews.Domain.Models
{
    public partial class SystemRoleReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateDate { get; set; }

        #endregion

    }
}
