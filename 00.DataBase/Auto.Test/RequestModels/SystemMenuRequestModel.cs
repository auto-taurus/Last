using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SystemMenuRequestModel
	{
		[Key]
		public Int32? MenuId { get; set; }

		public Int32? SiteNo { get; set; }

		[StringLength(20)]
		public String MenuIcon { get; set; }

		[StringLength(40)]
		public String MenuName { get; set; }

		public Int32? ParentId { get; set; }

		[StringLength(1000)]
		public String NodeValue { get; set; }

		[StringLength(100)]
		public String Areas { get; set; }

		[StringLength(100)]
		public String Controller { get; set; }

		[StringLength(100)]
		public String Action { get; set; }

		[StringLength(1000)]
		public String Urls { get; set; }

		[StringLength(100)]
		public String RouterName { get; set; }

		[StringLength(200)]
		public String RouterPath { get; set; }

		[StringLength(100)]
		public String Component { get; set; }

		public Int32? ShowAlways { get; set; }

		public Int32? ShowHeader { get; set; }

		public Int32? HideInBread { get; set; }

		public Int32? HideInMenu { get; set; }

		public Int32? NotCache { get; set; }

		public Int32? BeforeCloseName { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] RowVers { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
