using Auto.Commons.EfCore;
using System;
using System.Collections.Generic;

namespace Auto.Entities.Datas
{
    public partial class SystemUsersInRole
        : IEntity {
        public SystemUsersInRole()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }
        public int? UsersId { get; set; }

        public int? RoleId { get; set; }

        #endregion

        #region Generated Relationships
        public virtual SystemRole SystemRole { get; set; }

        public virtual SystemUsers SystemUsers { get; set; }

        #endregion

    }
}
