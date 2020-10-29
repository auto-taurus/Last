using System;
using System.Collections.ObjectModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemMenu : IEntity
	{
		public SystemMenu()
		{
		}

		public SystemMenu(Int32? menuId)
		{
			MenuId = menuId;
		}

		public Int32? MenuId { get; set; }

		public Int32? SiteId { get; set; }

		public String MenuIcon { get; set; }

		public String MenuName { get; set; }

		public Int32? ParentId { get; set; }

		public String NodeValue { get; set; }

		public String Areas { get; set; }

		public String Controller { get; set; }

		public String Action { get; set; }

		public String Urls { get; set; }

		public String RouterName { get; set; }

		public String RouterPath { get; set; }

		public String Component { get; set; }

		public Int32? ShowAlways { get; set; }

		public Int32? ShowHeader { get; set; }

		public Int32? HideInBread { get; set; }

		public Int32? HideInMenu { get; set; }

		public Int32? NotCache { get; set; }

		public Int32? BeforeCloseName { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] RowVers { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }

		public Collection<SystemRoleInMenu> SystemRoleInMenus { get; set; }

		public Collection<SystemUsersInMenu> SystemUsersInMenus { get; set; }
	}
}
