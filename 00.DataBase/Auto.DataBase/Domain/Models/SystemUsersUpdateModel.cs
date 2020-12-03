using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class SystemUsersUpdateModel
    {
        #region Generated Properties
        public int UsersId { get; set; }

        public string UsersName { get; set; }

        public string LoginName { get; set; }

        public string Password { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string LastLoginIp { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
