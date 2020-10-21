using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberProblemRequestModel
	{
		[Key]
		public Int32? ProblemId { get; set; }

		[StringLength(100)]
		public String Title { get; set; }

		[StringLength(510)]
		public String Desc { get; set; }

		public Int32? Type { get; set; }

		[StringLength(510)]
		public String Urls { get; set; }

		public Int32? IsHot { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
