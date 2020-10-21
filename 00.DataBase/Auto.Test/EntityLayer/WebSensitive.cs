using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebSensitive : IEntity
	{
		public WebSensitive()
		{
		}

		public WebSensitive(Int32? sensitiveId)
		{
			SensitiveId = sensitiveId;
		}

		public Int32? SensitiveId { get; set; }

		public Int32? SiteId { get; set; }

		public Int32? Type { get; set; }

		public String TypeText { get; set; }

		public String SensitiveWords { get; set; }

		public String Author { get; set; }

		public String Urls { get; set; }

		public Byte[] RowVers { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
