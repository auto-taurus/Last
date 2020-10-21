using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberFollowRequestModel
	{
		[Key]
		public Int32? FollowId { get; set; }

		public Int32? MemberId { get; set; }

		public Int32? SourceId { get; set; }

		[StringLength(20)]
		public String SourceTable { get; set; }

		public DateTime? FollowTime { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }
	}
}
