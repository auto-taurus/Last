using Auto.Commons.EfCore;
using System;
using System.Collections.Generic;

namespace Auto.Entities.Datas {
    public partial class SystemMenu
        : EntityBase {
        public SystemMenu() {
            #region Generated Constructor
            SystemRoles = new HashSet<SystemRoleInMenu>();
            SystemUsers = new HashSet<SystemUsersInMenu>();
            #endregion
        }

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

        public Byte[] RowVers { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<SystemRoleInMenu> SystemRoles { get; set; }

        public virtual ICollection<SystemUsersInMenu> SystemUsers { get; set; }

        #endregion

    }
}
