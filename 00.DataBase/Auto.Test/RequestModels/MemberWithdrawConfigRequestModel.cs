using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberWithdrawConfigRequestModel
	{
		[Key]
		public Int32? WithdrawConfigId { get; set; }

		public Int32? Methods { get; set; }

		[StringLength(20)]
		public String Tips { get; set; }

		[StringLength(5)]
		public String WithdrawTask { get; set; }

		public Decimal? Amount { get; set; }

		[StringLength(20)]
		public String AmountTips { get; set; }

		[StringLength(510)]
		public String AmountDesc { get; set; }

		[StringLength(5)]
		public String AmountTask { get; set; }

		[StringLength(510)]
		public String Desc { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(255)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
