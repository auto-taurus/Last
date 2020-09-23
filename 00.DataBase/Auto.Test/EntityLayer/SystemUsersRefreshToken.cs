using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsersRefreshToken : IEntity
	{
		public SystemUsersRefreshToken()
		{
		}

		public SystemUsersRefreshToken(Int32? refreshTokenId)
		{
			RefreshTokenId = refreshTokenId;
		}

		public Int32? RefreshTokenId { get; set; }

		public Int32? UsersId { get; set; }

		public String AccessToken { get; set; }

		public DateTime? Expires { get; set; }

		public Int32? Active { get; set; }
	}
}
