using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SystemUsersRequestModel
	{
		[Key]
		public Int32? UsersId { get; set; }

		[StringLength(40)]
		public String UsersName { get; set; }

		[StringLength(50)]
		public String LoginName { get; set; }

		[StringLength(50)]
		public String Password { get; set; }

		[StringLength(50)]
		public String MobilePhone { get; set; }

		[StringLength(50)]
		public String Email { get; set; }

		[StringLength(20)]
		public String LastLoginIp { get; set; }

		public DateTime? LastLoginTime { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
