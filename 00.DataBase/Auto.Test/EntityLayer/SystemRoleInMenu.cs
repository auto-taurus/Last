using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemRoleInMenu : IEntity
	{
		public SystemRoleInMenu()
		{
		}

		public Int32? RoleId { get; set; }

		public Int32? MenuId { get; set; }
	}
}
