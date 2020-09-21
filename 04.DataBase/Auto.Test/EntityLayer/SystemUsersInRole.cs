using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsersInRole : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_usersId;
		private Int32? m_roleId;

		public SystemUsersInRole()
		{
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

		public Int32? RoleId
		{
			get
			{
				return m_roleId;
			}
			set
			{
				if (m_roleId != value)
				{
					m_roleId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RoleId)));
				}
			}
		}
	}
}
