using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsersInMenu : IEntity
	{
		public SystemUsersInMenu()
		{
		}

		public Int32? UserId { get; set; }

		public Int32? MenuId { get; set; }
	}
}
