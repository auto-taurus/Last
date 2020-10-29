using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsersInMenu : IEntity
	{
		public SystemUsersInMenu()
		{
		}

		public SystemUsersInMenu(Int32? id)
		{
			Id = id;
		}

		public Int32? Id { get; set; }

		public Int32? UserId { get; set; }

		public Int32? MenuId { get; set; }

		public SystemMenu SystemMenuFk { get; set; }

		public SystemUsers SystemUsersFk { get; set; }
	}
}
