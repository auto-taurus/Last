using System;
using OnLineStoreCore.EntityLayer;
using System.Collections.ObjectModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebSource : IEntity
	{
		public WebSource()
		{
		}

		public WebSource(Int32? sourceId)
		{
			SourceId = sourceId;
		}

		public Int32? SourceId { get; set; }

		public Int32? CategoryId { get; set; }

		public String SourceName { get; set; }

		public String SourceLogo { get; set; }

		public Int32? FollowNumber { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		public DateTime? Remarks { get; set; }

		public WebCategory WebCategoryFk { get; set; }

		public Collection<WebNews> WebNews { get; set; }
	}
}
