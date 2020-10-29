using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberCommentUpRequestModel
	{
		[Key]
		public Int32? CommentUpId { get; set; }

		public Int32? CommentId { get; set; }

		public Int32? MemberId { get; set; }
	}
}
