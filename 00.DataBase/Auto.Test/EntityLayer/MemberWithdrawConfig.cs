using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberWithdrawConfig : IEntity
	{
		public MemberWithdrawConfig()
		{
		}

		public MemberWithdrawConfig(Int32? withdrawConfigId)
		{
			WithdrawConfigId = withdrawConfigId;
		}

		public Int32? WithdrawConfigId { get; set; }

		public Int32? Methods { get; set; }

		public String Tips { get; set; }

		public String WithdrawTask { get; set; }

		public Decimal? Amount { get; set; }

		public String AmountTips { get; set; }

		public String AmountDesc { get; set; }

		public String AmountTask { get; set; }

		public String Desc { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
