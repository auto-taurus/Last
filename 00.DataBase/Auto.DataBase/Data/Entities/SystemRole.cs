using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class SystemRole
    {
        public SystemRole()
        {
            #region Generated Constructor
            SystemRoleDictionaries = new HashSet<SystemRoleDictionary>();
            SystemRoleInMenus = new HashSet<SystemRoleInMenu>();
            SystemUsersInRoles = new HashSet<SystemUsersInRole>();
            #endregion
        }

        #region Generated Properties
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<SystemRoleDictionary> SystemRoleDictionaries { get; set; }

        public virtual ICollection<SystemRoleInMenu> SystemRoleInMenus { get; set; }

        public virtual ICollection<SystemUsersInRole> SystemUsersInRoles { get; set; }

        #endregion

    }
}
