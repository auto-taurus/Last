using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemRoleInMenu : IEntity
	{
		public SystemRoleInMenu()
		{
		}

		public SystemRoleInMenu(Int32? id)
		{
			Id = id;
		}

		public Int32? Id { get; set; }

		public Int32? RoleId { get; set; }

		public Int32? MenuId { get; set; }

		public SystemMenu SystemMenuFk { get; set; }

		public SystemRole SystemRoleFk { get; set; }
	}
}
