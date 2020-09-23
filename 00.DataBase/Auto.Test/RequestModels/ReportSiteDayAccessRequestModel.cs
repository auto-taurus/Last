using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class ReportSiteDayAccessRequestModel
	{
		[Key]
		public Int32? SiteAccessId { get; set; }

		[StringLength(10)]
		public String SiteNo { get; set; }

		public Int32? Count { get; set; }

		public DateTime? Today { get; set; }

		public DateTime? LastUpdateTime { get; set; }
	}
}
