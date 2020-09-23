using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities {
    public partial class SystemRole
        : EntityBase {
        public SystemRole() {
            #region Generated Constructor
            SystemRoleDictionaries = new HashSet<SystemRoleDictionary>();
            SystemMenus = new HashSet<SystemRoleInMenu>();
            SystemUsers = new HashSet<SystemUsersInRole>();
            #endregion
        }

        #region Generated Properties
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<SystemRoleDictionary> SystemRoleDictionaries { get; set; }

        public virtual ICollection<SystemRoleInMenu> SystemMenus { get; set; }

        public virtual ICollection<SystemUsersInRole> SystemUsers { get; set; }

        #endregion

    }
}
