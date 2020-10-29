using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberIncome : IEntity
	{
		public MemberIncome()
		{
		}

		public MemberIncome(Int32? incomeId)
		{
			IncomeId = incomeId;
		}

		public Int32? IncomeId { get; set; }

		public Int32? MemberId { get; set; }

		public String TaskCode { get; set; }

		public String TaksName { get; set; }

		public String Title { get; set; }

		public Int32? Beans { get; set; }

		public String BeansText { get; set; }

		public DateTime? CreateTime { get; set; }

		public String Proportion { get; set; }

		public Int32? ReadTime { get; set; }

		public Int32? Status { get; set; }

		public String Remarks { get; set; }

		public Int32? AuditId { get; set; }

		public String Audit { get; set; }

		public DateTime? AuditTime { get; set; }

		public MemberInfos MemberInfosFk { get; set; }
	}
}
