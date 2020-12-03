using Auto.Commons.EfCore;
using System;
using System.Collections.Generic;

namespace Auto.Entities.Modals {
    public partial class SystemUsers
        : EntityBase {
        public SystemUsers() {
            #region Generated Constructor
            SystemUsersInRoles = new HashSet<SystemUsersInRole>();
            SystemUsersInMenus = new HashSet<SystemUsersInMenu>();
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
        public virtual ICollection<SystemUsersInRole> SystemUsersInRoles { get; set; }
        public virtual ICollection<SystemUsersDictionary> SystemUsersDictionaries { get; set; }
        public virtual ICollection<SystemUsersInMenu> SystemUsersInMenus { get; set; }
        #endregion

    }
}
