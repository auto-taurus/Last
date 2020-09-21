using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class WebNewsOperateLogsRequestModel
	{
		[Key]
		public Int32? NewsOperateId { get; set; }

		public Int32? NewsId { get; set; }

		[StringLength(40)]
		public String OperateType { get; set; }

		[StringLength(510)]
		public String OperateStatus { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		[StringLength(40)]
		public String CreateName { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
