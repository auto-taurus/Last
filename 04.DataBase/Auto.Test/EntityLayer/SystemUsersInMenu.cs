using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsersInMenu : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_userId;
		private Int32? m_menuId;

		public SystemUsersInMenu()
		{
		}

		public Int32? UserId
		{
			get
			{
				return m_userId;
			}
			set
			{
				if (m_userId != value)
				{
					m_userId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserId)));
				}
			}
		}

		public Int32? MenuId
		{
			get
			{
				return m_menuId;
			}
			set
			{
				if (m_menuId != value)
				{
					m_menuId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MenuId)));
				}
			}
		}
	}
}
