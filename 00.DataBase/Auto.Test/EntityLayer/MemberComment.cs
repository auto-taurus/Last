using System;
using OnLineStoreCore.EntityLayer;
using System.Collections.ObjectModel;

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

		public Int32? MemberId { get; set; }

		public String MemberName { get; set; }

		public String CommentBody { get; set; }

		public DateTime? CommentTime { get; set; }

		public Int32? QuoteId { get; set; }

		public String QuoteName { get; set; }

		public Int32? Up { get; set; }

		public Int32? Number { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public MemberInfos MemberInfosFk { get; set; }

		public WebNews WebNewsFk { get; set; }

		public Collection<MemberCommentUp> MemberCommentUps { get; set; }
	}
}
