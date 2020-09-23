using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class SystemRoleInMenu
        : EntityBase
    {
        public SystemRoleInMenu()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int? RoleId { get; set; }

        public int? MenuId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SystemMenu SystemMenu { get; set; }

        public virtual SystemRole SystemRole { get; set; }

        #endregion

    }
}
