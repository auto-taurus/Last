using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class SystemRoleInMenuRequestModel
	{
		public Int32? RoleId { get; set; }

		public Int32? MenuId { get; set; }
	}
}
