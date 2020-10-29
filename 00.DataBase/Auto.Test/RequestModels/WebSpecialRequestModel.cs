using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class WebSpecialRequestModel
	{
		[Key]
		public Int32? SpecialId { get; set; }

		public Int32? SiteId { get; set; }

		[StringLength(10)]
		public String SpecialCode { get; set; }

		[StringLength(100)]
		public String Name { get; set; }

		public Int32? DisplayType { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] RowVers { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
