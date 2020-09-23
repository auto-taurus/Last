using System;
using System.Collections.ObjectModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsers : IEntity
	{
		public SystemUsers()
		{
		}

		public SystemUsers(Int32? usersId)
		{
			UsersId = usersId;
		}

		public Int32? UsersId { get; set; }

		public String UsersName { get; set; }

		public String LoginName { get; set; }

		public String Password { get; set; }

		public String MobilePhone { get; set; }

		public String Email { get; set; }

		public String LoginIp { get; set; }

		public DateTime? LoginTime { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }

		public Collection<SystemUsersDictionary> SystemUsersDictionaries { get; set; }
	}
}
