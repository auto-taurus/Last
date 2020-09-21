using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class SystemUsersInRoleRequestModel
	{
		public Int32? UsersId { get; set; }

		public Int32? RoleId { get; set; }
	}
}
