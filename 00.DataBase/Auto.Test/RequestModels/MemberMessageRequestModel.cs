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

		public Int32? LeaveType { get; set; }

		public DateTime? CreateTime { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }
	}
}
