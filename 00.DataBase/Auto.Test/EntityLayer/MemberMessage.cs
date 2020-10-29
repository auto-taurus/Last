using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberMessage : IEntity
	{
		public MemberMessage()
		{
		}

		public MemberMessage(Int32? messageId)
		{
			MessageId = messageId;
		}

		public Int32? MessageId { get; set; }

		public Int32? MemberId { get; set; }

		public String MemberName { get; set; }

		public String LeaveBody { get; set; }

		public Int32? LeaveType { get; set; }

		public DateTime? CreateTime { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public MemberInfos MemberInfosFk { get; set; }
	}
}
