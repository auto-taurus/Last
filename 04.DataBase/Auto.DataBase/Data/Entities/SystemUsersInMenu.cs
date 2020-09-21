using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class SystemUsersInMenu
        : IBaseEntity
    {
        public SystemUsersInMenu()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int? UserId { get; set; }

        public int? MenuId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SystemMenu SystemMenu { get; set; }

        public virtual SystemUsers UserSystemUsers { get; set; }

        #endregion

    }
}
