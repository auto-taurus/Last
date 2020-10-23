using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class WebNewsRequestModel
	{
		[Key]
		[StringLength(12)]
		public String NewsId { get; set; }

		public Int32? SiteId { get; set; }

		[StringLength(10)]
		public String SpecialCode { get; set; }

		public Int32? CategoryId { get; set; }

		[StringLength(100)]
		public String CategoryName { get; set; }

		[StringLength(1000)]
		public String NewsTitle { get; set; }

		[StringLength(1000)]
		public String CustomTitle { get; set; }

		public Int32? SourceId { get; set; }

		[StringLength(100)]
		public String Source { get; set; }

		[StringLength(2000)]
		public String SourceAddress { get; set; }

		[StringLength(2000)]
		public String SourceLogo { get; set; }

		[StringLength(510)]
		public String Tags { get; set; }

		public String Contents { get; set; }

		[StringLength(50)]
		public String Controller { get; set; }

		[StringLength(50)]
		public String Action { get; set; }

		[StringLength(2000)]
		public String Urls { get; set; }

		[StringLength(4000)]
		public String ImageThums { get; set; }

		[StringLength(4000)]
		public String ImagePaths { get; set; }

		public Int32? DisplayType { get; set; }

		public Int32? IsHot { get; set; }

		[StringLength(510)]
		public String Title { get; set; }

		[StringLength(510)]
		public String Keywords { get; set; }

		[StringLength(510)]
		public String Description { get; set; }

		public Int32? AccessNumber { get; set; }

		public Int32? VirtualAccessNumber { get; set; }

		public Int32? ClickNumber { get; set; }

		public Int32? Author { get; set; }

		[StringLength(100)]
		public String AuditBy { get; set; }

		public Int32? AuditStatus { get; set; }

		public DateTime? AuditTime { get; set; }

		[StringLength(100)]
		public String PushBy { get; set; }

		public Int32? PushStatus { get; set; }

		public DateTime? PushTime { get; set; }

		public Int32? OperateType { get; set; }

		public Int32? CategorySort { get; set; }

		public Int32? SingleSort { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] RowVers { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
