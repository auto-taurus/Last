using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberLoginLogRequestModel
	{
		[Key]
		public Decimal? LoginLogId { get; set; }

		[StringLength(10)]
		public String Source { get; set; }

		[StringLength(10)]
		public String Column3 { get; set; }

		[StringLength(10)]
		public String Column4 { get; set; }
	}
}
