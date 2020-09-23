using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SystemUsersInRoleRequestModel
	{
		public Int32? UsersId { get; set; }

		public Int32? RoleId { get; set; }
	}
}
