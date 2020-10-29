using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class ReportCategoryDayAccessRequestModel
	{
		[Key]
		public Int32? CategoryAccessId { get; set; }

		public Int32? CategoryId { get; set; }

		[StringLength(100)]
		public String CategoryName { get; set; }

		public Int32? Count { get; set; }

		public DateTime? Today { get; set; }

		public DateTime? LastUpdateTime { get; set; }
	}
}
