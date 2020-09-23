using System;
using System.Collections.ObjectModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemRole : IEntity
	{
		public SystemRole()
		{
		}

		public SystemRole(Int32? roleId)
		{
			RoleId = roleId;
		}

		public Int32? RoleId { get; set; }

		public String RoleName { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateDate { get; set; }

		public Collection<SystemRoleDictionary> SystemRoleDictionaries { get; set; }
	}
}
