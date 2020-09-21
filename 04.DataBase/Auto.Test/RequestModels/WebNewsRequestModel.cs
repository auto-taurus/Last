using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class WebNewsRequestModel
	{
		[Key]
		public Int32? NewsId { get; set; }

		public Int32? SiteId { get; set; }

		public Int32? CategoryId { get; set; }

		[StringLength(100)]
		public String CategoryName { get; set; }

		[StringLength(1000)]
		public String NewsTitle { get; set; }

		[StringLength(1000)]
		public String CustomTitle { get; set; }

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

		public Int32? ClickNumber { get; set; }

		[StringLength(100)]
		public String AuditName { get; set; }

		public Int32? AuditStatus { get; set; }

		public DateTime? AuditTime { get; set; }

		public Int32? PushStatus { get; set; }

		[StringLength(100)]
		public String PushName { get; set; }

		public DateTime? PushTime { get; set; }

		public Int32? OperateType { get; set; }

		public Int32? CategorySort { get; set; }

		public Int32? SingleSort { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] Timestamp { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
