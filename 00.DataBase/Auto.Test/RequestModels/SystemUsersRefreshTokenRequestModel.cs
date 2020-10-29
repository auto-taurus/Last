using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SystemUsersRefreshTokenRequestModel
	{
		[Key]
		public Int32? RefreshTokenId { get; set; }

		public Int32? UsersId { get; set; }

		[StringLength(1000)]
		public String AccessToken { get; set; }

		public DateTime? Expires { get; set; }

		public Int32? Active { get; set; }
	}
}
