using System;
using System.Collections.ObjectModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebCategory : IEntity
	{
		public WebCategory()
		{
		}

		public WebCategory(Int32? categoryId)
		{
			CategoryId = categoryId;
		}

		public Int32? CategoryId { get; set; }

		public Int32? SiteNo { get; set; }

		public String CategoryName { get; set; }

		public Int32? ParentId { get; set; }

		public String NodeValue { get; set; }

		public String Controller { get; set; }

		public String Action { get; set; }

		public String Urls { get; set; }

		public Int32? DocumentNumber { get; set; }

		public Int32? VirtualAccessNumber { get; set; }

		public Int32? AccessNumber { get; set; }

		public Int32? ClickNumber { get; set; }

		public String Title { get; set; }

		public String Keywords { get; set; }

		public String Description { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] RowVers { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }

		public Collection<WebNews> WebNews { get; set; }
	}
}
