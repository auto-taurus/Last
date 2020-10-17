using Auto.Commons.EfCore;
using System;
using System.Collections.Generic;

namespace Auto.Entities.Datas {
    public partial class SystemUsers
        : EntityBase {
        public SystemUsers() {
            #region Generated Constructor
            SystemRoles = new HashSet<SystemUsersInRole>();
            SystemMenus = new HashSet<SystemUsersInMenu>();
            SystemUsersDictionaries = new HashSet<SystemUsersDictionary>();
            #endregion
        }

        #region Generated Properties
        public int UsersId { get; set; }

        public string UsersName { get; set; }

        public string LoginName { get; set; }

        public string Password { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string LoginIp { get; set; }

        public DateTime? LoginTime { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<SystemUsersInRole> SystemRoles { get; set; }
        public virtual ICollection<SystemUsersInMenu> SystemMenus { get; set; }
        public virtual ICollection<SystemUsersDictionary> SystemUsersDictionaries { get; set; }
        #endregion

    }
}
