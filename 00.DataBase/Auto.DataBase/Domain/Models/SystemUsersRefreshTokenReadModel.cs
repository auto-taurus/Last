using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class SystemUsersRefreshTokenReadModel
    {
        #region Generated Properties
        public int RefreshTokenId { get; set; }

        public int? UsersId { get; set; }

        public string AccessToken { get; set; }

        public DateTime? Expires { get; set; }

        public int? Active { get; set; }

        #endregion

    }
}
