using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SystemRoleInMenuRequestModel
	{
		public Int32? RoleId { get; set; }

		public Int32? MenuId { get; set; }
	}
}
