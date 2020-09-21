using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class SystemLogsRequestModel
	{
		[Key]
		public Int32? LogsId { get; set; }

		[StringLength(100)]
		public String Methods { get; set; }

		public Int32? Grade { get; set; }

		[StringLength(50)]
		public String Source { get; set; }

		[StringLength(4000)]
		public String Args { get; set; }

		[StringLength(4000)]
		public String Errors { get; set; }

		public Int32? CreateBy { get; set; }

		[Required]
		public DateTime? CreateTime { get; set; }
	}
}
