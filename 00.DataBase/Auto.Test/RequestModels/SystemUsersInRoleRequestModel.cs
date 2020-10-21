using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SystemUsersInRoleRequestModel
	{
		[Key]
		public Int32? Id { get; set; }

		public Int32? UsersId { get; set; }

		public Int32? RoleId { get; set; }
	}
}
