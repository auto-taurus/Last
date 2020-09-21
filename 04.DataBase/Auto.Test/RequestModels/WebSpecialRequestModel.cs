using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class WebSpecialRequestModel
	{
		[Key]
		public Int32? SpecialId { get; set; }

		public Int32? SiteNo { get; set; }

		[Required]
		[StringLength(10)]
		public String SpecialCode { get; set; }

		[StringLength(100)]
		public String Name { get; set; }

		public Int32? DisplayType { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] Timestamp { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
