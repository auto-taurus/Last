using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class ReportNewsDayClickRequestModel
	{
		[Key]
		public Int32? NewsClickId { get; set; }

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
