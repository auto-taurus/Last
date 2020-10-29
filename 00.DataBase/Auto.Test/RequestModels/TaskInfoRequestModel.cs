using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class TaskInfoRequestModel
	{
		[Key]
		public Int32? TaskId { get; set; }

		[StringLength(5)]
		public String TaskCode { get; set; }

		[StringLength(50)]
		public String RelatedTasks { get; set; }

		[StringLength(40)]
		public String TaskName { get; set; }

		[StringLength(100)]
		public String Desc { get; set; }

		[StringLength(200)]
		public String SaveDesc { get; set; }

		public Int32? CategoryDay { get; set; }

		public Int32? CategoryFixed { get; set; }

		[StringLength(100)]
		public String Platform { get; set; }

		public Int64? Beans { get; set; }

		[StringLength(40)]
		public String BeansText { get; set; }

		public Int32? IsDisplay { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
