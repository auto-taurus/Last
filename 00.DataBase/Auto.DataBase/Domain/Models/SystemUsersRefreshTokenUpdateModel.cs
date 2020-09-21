using System;
using System.Collections.Generic;

namespace Company.AutoNews.Domain.Models
{
    public partial class SystemUsersRefreshTokenUpdateModel
        : EntityUpdateModel
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
