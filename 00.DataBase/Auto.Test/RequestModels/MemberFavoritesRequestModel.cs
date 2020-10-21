using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberFavoritesRequestModel
	{
		[Key]
		public Int32? FavoritesId { get; set; }

		public Int32? MemberId { get; set; }

		[StringLength(20)]
		public String SourceId { get; set; }

		[StringLength(20)]
		public String SourceTable { get; set; }

		public DateTime? FavoritesTime { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }
	}
}
