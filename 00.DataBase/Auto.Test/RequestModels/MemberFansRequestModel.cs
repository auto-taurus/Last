using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberFansRequestModel
	{
		[Key]
		public Int32? FansId { get; set; }

		public Int32? MemberId { get; set; }

		public Int32? MemberFansId { get; set; }

		[StringLength(100)]
		public String MemberFansName { get; set; }

		public DateTime? FollowTime { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }
	}
}
