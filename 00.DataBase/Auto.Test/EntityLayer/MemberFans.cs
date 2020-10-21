using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberFans : IEntity
	{
		public MemberFans()
		{
		}

		public MemberFans(Int32? fansId)
		{
			FansId = fansId;
		}

		public Int32? FansId { get; set; }

		public Int32? MemberId { get; set; }

		public Int32? MemberFansId { get; set; }

		public String MemberFansName { get; set; }

		public DateTime? FollowTime { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public MemberInfos MemberInfosFk { get; set; }
	}
}
