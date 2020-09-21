using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class SystemMenu
        : EntityBase
    {
        public SystemMenu()
        {
            #region Generated Constructor
            SystemRoleInMenus = new HashSet<SystemRoleInMenu>();
            SystemUsersInMenus = new HashSet<SystemUsersInMenu>();
            #endregion
        }

        #region Generated Properties
        public int MenuId { get; set; }

        public int? SiteNo { get; set; }

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

        public int? IsEnable { get; set; }

        public Byte[] Timestamp { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<SystemRoleInMenu> SystemRoleInMenus { get; set; }

        public virtual ICollection<SystemUsersInMenu> SystemUsersInMenus { get; set; }

        #endregion

    }
}
