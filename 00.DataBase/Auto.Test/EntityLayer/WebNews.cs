using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebNews : IEntity
	{
		public WebNews()
		{
		}

		public WebNews(String newsId)
		{
			NewsId = newsId;
		}

		public String NewsId { get; set; }

		public Int32? SiteId { get; set; }

		public String SpecialCode { get; set; }

		public Int32? CategoryId { get; set; }

		public String CategoryName { get; set; }

		public String NewsTitle { get; set; }

		public String CustomTitle { get; set; }

		public Int32? SourceId { get; set; }

		public String Source { get; set; }

		public String SourceAddress { get; set; }

		public String SourceLogo { get; set; }

		public String Tags { get; set; }

		public String Contents { get; set; }

		public String Controller { get; set; }

		public String Action { get; set; }

		public String Urls { get; set; }

		public String ImageThums { get; set; }

		public String ImagePaths { get; set; }

		public Int32? DisplayType { get; set; }

		public Int32? IsHot { get; set; }

		public String Title { get; set; }

		public String Keywords { get; set; }

		public String Description { get; set; }

		public Int32? AccessNumber { get; set; }

		public Int32? VirtualAccessNumber { get; set; }

		public Int32? ClickNumber { get; set; }

		public Int32? Author { get; set; }

		public String AuditBy { get; set; }

		public Int32? AuditStatus { get; set; }

		public DateTime? AuditTime { get; set; }

		public String PushBy { get; set; }

		public Int32? PushStatus { get; set; }

		public DateTime? PushTime { get; set; }

		public Int32? OperateType { get; set; }

		public Int32? CategorySort { get; set; }

		public Int32? SingleSort { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] RowVers { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }

		public WebCategory WebCategoryFk { get; set; }

		public WebSource WebSourceFk { get; set; }
	}
}
