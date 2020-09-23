using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class ReportNewsDayAccessRequestModel
	{
		[Key]
		public Int32? NewsAccessId { get; set; }

		public Int32? NewsId { get; set; }

		public Int32? CategoryId { get; set; }

		[StringLength(100)]
		public String CategoryName { get; set; }

		public Int32? SpecialCode { get; set; }

		[StringLength(100)]
		public String SpecialName { get; set; }

		public Int32? Count { get; set; }

		public DateTime? Today { get; set; }

		public DateTime? LastUpdateTime { get; set; }
	}
}
