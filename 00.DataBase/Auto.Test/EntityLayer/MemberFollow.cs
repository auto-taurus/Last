using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberFollow : IEntity
	{
		public MemberFollow()
		{
		}

		public MemberFollow(Int32? followId)
		{
			FollowId = followId;
		}

		public Int32? FollowId { get; set; }

		public Int32? MemberId { get; set; }

		public Int32? SourceId { get; set; }

		public String SourceTable { get; set; }

		public DateTime? FollowTime { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public MemberInfos MemberInfosFk { get; set; }
	}
}
