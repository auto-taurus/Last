using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class WebNewsSensitiveRequestModel
	{
		[Key]
		public Int32? NewsSensitiveId { get; set; }

		public Int32? SiteMark { get; set; }

		public Int32? NewId { get; set; }

		[StringLength(2000)]
		public String NewTitleRecords { get; set; }

		[StringLength(2000)]
		public String CustomTitleRecords { get; set; }

		[StringLength(2000)]
		public String ContentsRecords { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(2000)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
