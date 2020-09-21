using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class SystemRole
        : IBaseEntity
    {
        public SystemRole()
        {
            #region Generated Constructor
            SystemRoleInDictionaries = new HashSet<SystemRoleInDictionary>();
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

        public DateTime? CreateDate { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<SystemRoleInDictionary> SystemRoleInDictionaries { get; set; }

        public virtual ICollection<SystemRoleInMenu> SystemRoleInMenus { get; set; }

        public virtual ICollection<SystemUsersInRole> SystemUsersInRoles { get; set; }

        #endregion

    }
}
