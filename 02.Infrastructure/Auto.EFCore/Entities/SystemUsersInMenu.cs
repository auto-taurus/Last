using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class SystemUsersInMenu
        : IEntity
    {
        public SystemUsersInMenu()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }
        public int? UserId { get; set; }

        public int? MenuId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SystemMenu SystemMenu { get; set; }

        public virtual SystemUsers SystemUsers { get; set; }

        #endregion

    }
}
