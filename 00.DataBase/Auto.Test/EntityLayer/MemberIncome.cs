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

		public Int32? TaskId { get; set; }

		public String TaskCode { get; set; }

		public String TaskName { get; set; }

		public Int32? CategoryDay { get; set; }

		public Int32? CategoryFixed { get; set; }

		public String Title { get; set; }

		public Int32? Beans { get; set; }

		public String BeansText { get; set; }

		public Int32? Number { get; set; }

		public DateTime? CreateTime { get; set; }

		public String Proportion { get; set; }

		public Int32? ReadTime { get; set; }

		public Int32? Status { get; set; }

		public Int32? AuditBy { get; set; }

		public String AuditName { get; set; }

		public DateTime? AuditTime { get; set; }

		public String Remarks { get; set; }

		public MemberInfos MemberInfosFk { get; set; }

		public TaskInfo TaskInfoFk { get; set; }
	}
}
