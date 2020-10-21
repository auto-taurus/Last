using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberMessageRequestModel
	{
		[Key]
		public Int32? MessageId { get; set; }

		public Int32? MemberId { get; set; }

		[StringLength(40)]
		public String MemberName { get; set; }

		[StringLength(510)]
		public String LeaveBody { get; set; }

		public DateTime? LeaveTime { get; set; }

		public Int32? CustomerId { get; set; }

		[StringLength(40)]
		public String CustomerName { get; set; }

		[StringLength(510)]
		public String ReplyBody { get; set; }

		public DateTime? ReplyTime { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }
	}
}
