using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberIncomeRequestModel
	{
		[Key]
		public Int32? IncomeId { get; set; }

		public Int32? MemberId { get; set; }

		public Int32? TaskId { get; set; }

		[StringLength(5)]
		public String TaskCode { get; set; }

		[StringLength(40)]
		public String TaskName { get; set; }

		public Int32? CategoryDay { get; set; }

		public Int32? CategoryFixed { get; set; }

		[StringLength(200)]
		public String Title { get; set; }

		public Int32? Beans { get; set; }

		[StringLength(40)]
		public String BeansText { get; set; }

		public Int32? Number { get; set; }

		public DateTime? CreateTime { get; set; }

		[StringLength(20)]
		public String Proportion { get; set; }

		public Int32? ReadTime { get; set; }

		public Int32? Status { get; set; }

		public Int32? AuditBy { get; set; }

		[StringLength(100)]
		public String AuditName { get; set; }

		public DateTime? AuditTime { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }
	}
}
