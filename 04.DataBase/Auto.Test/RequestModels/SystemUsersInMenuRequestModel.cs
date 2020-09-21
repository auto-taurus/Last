using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class SystemUsersInMenuRequestModel
	{
		public Int32? UserId { get; set; }

		public Int32? MenuId { get; set; }
	}
}
