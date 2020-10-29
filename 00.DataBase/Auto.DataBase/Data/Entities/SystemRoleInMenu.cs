using System;
using System.Collections.Generic;

namespace Master.Data.Entities
{
    public partial class SystemRoleInMenu
    {
        public SystemRoleInMenu()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public int? RoleId { get; set; }

        public int? MenuId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SystemMenu SystemMenu { get; set; }

        public virtual SystemRole SystemRole { get; set; }

        #endregion

    }
}
