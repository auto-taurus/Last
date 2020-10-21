using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class WebCategoryRequestModel
	{
		[Key]
		public Int32? CategoryId { get; set; }

		public Int32? SiteId { get; set; }

		[StringLength(40)]
		public String CategoryName { get; set; }

		public Int32? ParentId { get; set; }

		[StringLength(1000)]
		public String NodeValue { get; set; }

		[StringLength(50)]
		public String Controller { get; set; }

		[StringLength(50)]
		public String Action { get; set; }

		[StringLength(500)]
		public String Urls { get; set; }

		public Int32? DocumentNumber { get; set; }

		public Int32? AccessNumber { get; set; }

		public Int32? ClickNumber { get; set; }

		[StringLength(255)]
		public String Title { get; set; }

		[StringLength(255)]
		public String Keywords { get; set; }

		[StringLength(255)]
		public String Description { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] RowVers { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
