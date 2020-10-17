using Auto.Commons.EfCore;
using System;
using System.Collections.Generic;

namespace Auto.Entities.Datas
{
    public partial class SystemUsersRefreshToken
        : IEntity
    {
        public SystemUsersRefreshToken()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int RefreshTokenId { get; set; }

        public int? UsersId { get; set; }

        public string AccessToken { get; set; }

        public DateTime? Expires { get; set; }

        public int? Active { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
