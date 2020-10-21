using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberCommentSensitiveRequestModel
	{
		[Key]
		public Int32? CommentSensitiveId { get; set; }

		[StringLength(40)]
		public String SensitiveWords { get; set; }

		[StringLength(40)]
		public String ReplaceValue { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
