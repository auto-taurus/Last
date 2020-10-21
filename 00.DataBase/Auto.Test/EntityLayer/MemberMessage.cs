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

		public DateTime? LeaveTime { get; set; }

		public Int32? CustomerId { get; set; }

		public String CustomerName { get; set; }

		public String ReplyBody { get; set; }

		public DateTime? ReplyTime { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public MemberInfos MemberInfosFk { get; set; }
	}
}
