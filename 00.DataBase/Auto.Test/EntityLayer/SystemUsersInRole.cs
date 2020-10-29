using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsersInRole : IEntity
	{
		public SystemUsersInRole()
		{
		}

		public SystemUsersInRole(Int32? id)
		{
			Id = id;
		}

		public Int32? Id { get; set; }

		public Int32? UsersId { get; set; }

		public Int32? RoleId { get; set; }

		public SystemRole SystemRoleFk { get; set; }

		public SystemUsers SystemUsersFk { get; set; }
	}
}
