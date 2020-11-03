using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class SystemUsers
    {
        public SystemUsers()
        {
            #region Generated Constructor
            SystemUsersInRoles = new HashSet<SystemUsersInRole>();
            UserSystemUsersDictionaries = new HashSet<SystemUsersDictionary>();
            UserSystemUsersInMenus = new HashSet<SystemUsersInMenu>();
            #endregion
        }

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

        #region Generated Relationships
        public virtual ICollection<SystemUsersInRole> SystemUsersInRoles { get; set; }

        public virtual ICollection<SystemUsersDictionary> UserSystemUsersDictionaries { get; set; }

        public virtual ICollection<SystemUsersInMenu> UserSystemUsersInMenus { get; set; }

        #endregion

    }
}
