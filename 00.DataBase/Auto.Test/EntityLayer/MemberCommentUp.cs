using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberCommentUp : IEntity
	{
		public MemberCommentUp()
		{
		}

		public MemberCommentUp(Int32? commentUpId)
		{
			CommentUpId = commentUpId;
		}

		public Int32? CommentUpId { get; set; }

		public Int32? CommentId { get; set; }

		public Int32? MemberId { get; set; }

		public MemberComment MemberCommentFk { get; set; }
	}
}
