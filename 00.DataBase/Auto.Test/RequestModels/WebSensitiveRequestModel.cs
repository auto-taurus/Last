using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class WebSensitiveRequestModel
	{
		[Key]
		public Int32? SensitiveId { get; set; }

		public Int32? SiteNo { get; set; }

		public Int32? Type { get; set; }

		[StringLength(40)]
		public String TypeText { get; set; }

		[StringLength(100)]
		public String SensitiveWords { get; set; }

		[StringLength(2000)]
		public String Author { get; set; }

		[StringLength(8000)]
		public String Urls { get; set; }

		public Byte[] RowVers { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
