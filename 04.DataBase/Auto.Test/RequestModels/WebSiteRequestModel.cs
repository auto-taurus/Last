using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class WebSiteRequestModel
	{
		[Key]
		public Int32? SiteId { get; set; }

		public Int32? SiteNo { get; set; }

		[StringLength(100)]
		public String SiteName { get; set; }

		[StringLength(255)]
		public String SiteUrls { get; set; }

		[StringLength(255)]
		public String LogoUrls { get; set; }

		public Int32? Count { get; set; }

		[StringLength(255)]
		public String Title { get; set; }

		[StringLength(255)]
		public String Keywords { get; set; }

		[StringLength(255)]
		public String Description { get; set; }

		public Byte[] Timestamp { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
