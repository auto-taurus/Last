using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberWithdrawRequestModel
	{
		[Key]
		public Int64? WithdrawId { get; set; }

		public Int32? MemberId { get; set; }

		public Int32? Methods { get; set; }

		[StringLength(100)]
		public String Title { get; set; }

		public Int32? Beans { get; set; }

		public Decimal? Amount { get; set; }

		[StringLength(20)]
		public String Proportion { get; set; }

		public DateTime? CreateTime { get; set; }

		public Int32? Status { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? AuditId { get; set; }

		[StringLength(100)]
		public String Audit { get; set; }

		public DateTime? AuditTime { get; set; }
	}
}
