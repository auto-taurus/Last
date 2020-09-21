using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsersRefreshToken : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_refreshTokenId;
		private Int32? m_usersId;
		private String m_accessToken;
		private DateTime? m_expires;
		private Int32? m_active;

		public SystemUsersRefreshToken()
		{
		}

		public SystemUsersRefreshToken(Int32? refreshTokenId)
		{
			RefreshTokenId = refreshTokenId;
		}

		public Int32? RefreshTokenId
		{
			get
			{
				return m_refreshTokenId;
			}
			set
			{
				if (m_refreshTokenId != value)
				{
					m_refreshTokenId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RefreshTokenId)));
				}
			}
		}

		public Int32? UsersId
		{
			get
			{
				return m_usersId;
			}
			set
			{
				if (m_usersId != value)
				{
					m_usersId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UsersId)));
				}
			}
		}

		public String AccessToken
		{
			get
			{
				return m_accessToken;
			}
			set
			{
				if (m_accessToken != value)
				{
					m_accessToken = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AccessToken)));
				}
			}
		}

		public DateTime? Expires
		{
			get
			{
				return m_expires;
			}
			set
			{
				if (m_expires != value)
				{
					m_expires = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Expires)));
				}
			}
		}

		public Int32? Active
		{
			get
			{
				return m_active;
			}
			set
			{
				if (m_active != value)
				{
					m_active = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Active)));
				}
			}
		}
	}
}
