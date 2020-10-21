using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberCommentRequestModel
	{
		[Key]
		public Int32? CommentId { get; set; }

		[StringLength(12)]
		public String NewsId { get; set; }

		public Int32? ParentId { get; set; }

		public Int32? OCommentId { get; set; }

		[StringLength(40)]
		public String OCommentName { get; set; }

		[StringLength(510)]
		public String OCommentBody { get; set; }

		public Int32? TCommentId { get; set; }

		[StringLength(40)]
		public String TCommentName { get; set; }

		[StringLength(510)]
		public String TCommentBody { get; set; }

		public DateTime? CommentTime { get; set; }

		public Int32? QuoteId { get; set; }

		[StringLength(40)]
		public String QuoteName { get; set; }

		public Int32? Up { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }
	}
}
