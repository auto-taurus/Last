using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberWithdraw : IEntity
	{
		public MemberWithdraw()
		{
		}

		public MemberWithdraw(Int64? withdrawId)
		{
			WithdrawId = withdrawId;
		}

		public Int64? WithdrawId { get; set; }

		public Int32? MemberId { get; set; }

		public Int32? Methods { get; set; }

		public String Title { get; set; }

		public Int32? Beans { get; set; }

		public Decimal? Amount { get; set; }

		public String Proportion { get; set; }

		public DateTime? CreateTime { get; set; }

		public Int32? Status { get; set; }

		public String Remarks { get; set; }

		public Int32? AuditId { get; set; }

		public String Audit { get; set; }

		public DateTime? AuditTime { get; set; }

		public MemberInfos MemberInfosFk { get; set; }
	}
}
