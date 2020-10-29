using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberCommentSensitive : IEntity
	{
		public MemberCommentSensitive()
		{
		}

		public MemberCommentSensitive(Int32? commentSensitiveId)
		{
			CommentSensitiveId = commentSensitiveId;
		}

		public Int32? CommentSensitiveId { get; set; }

		public String SensitiveWords { get; set; }

		public String ReplaceValue { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
