using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsersInRole : IEntity
	{
		public SystemUsersInRole()
		{
		}

		public Int32? UsersId { get; set; }

		public Int32? RoleId { get; set; }
	}
}
