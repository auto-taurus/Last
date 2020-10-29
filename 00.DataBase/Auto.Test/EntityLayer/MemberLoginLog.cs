using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberLoginLog : IEntity
	{
		public MemberLoginLog()
		{
		}

		public MemberLoginLog(Decimal? loginLogId)
		{
			LoginLogId = loginLogId;
		}

		public Decimal? LoginLogId { get; set; }

		public String Source { get; set; }

		public String Column3 { get; set; }

		public String Column4 { get; set; }
	}
}
