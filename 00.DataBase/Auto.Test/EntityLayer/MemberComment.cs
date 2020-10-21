using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberComment : IEntity
	{
		public MemberComment()
		{
		}

		public MemberComment(Int32? commentId)
		{
			CommentId = commentId;
		}

		public Int32? CommentId { get; set; }

		public String NewsId { get; set; }

		public Int32? ParentId { get; set; }

		public Int32? OCommentId { get; set; }

		public String OCommentName { get; set; }

		public String OCommentBody { get; set; }

		public Int32? TCommentId { get; set; }

		public String TCommentName { get; set; }

		public String TCommentBody { get; set; }

		public DateTime? CommentTime { get; set; }

		public Int32? QuoteId { get; set; }

		public String QuoteName { get; set; }

		public Int32? Up { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public WebNews WebNewsFk { get; set; }
	}
}
