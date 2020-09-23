using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class SystemUsersInRole
    {
        public SystemUsersInRole()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int? UsersId { get; set; }

        public int? RoleId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SystemRole SystemRole { get; set; }

        public virtual SystemUsers SystemUsers { get; set; }

        #endregion

    }
}
