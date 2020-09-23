using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SystemUsersInMenuRequestModel
	{
		public Int32? UserId { get; set; }

		public Int32? MenuId { get; set; }
	}
}
