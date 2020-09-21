using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemRoleInMenu : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_roleId;
		private Int32? m_menuId;

		public SystemRoleInMenu()
		{
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
