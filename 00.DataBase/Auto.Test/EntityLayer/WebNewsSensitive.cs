using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebNewsSensitive : IEntity
	{
		public WebNewsSensitive()
		{
		}

		public WebNewsSensitive(Int32? newsSensitiveId)
		{
			NewsSensitiveId = newsSensitiveId;
		}

		public Int32? NewsSensitiveId { get; set; }

		public Int32? SiteMark { get; set; }

		public Int32? NewId { get; set; }

		public String NewTitleRecords { get; set; }

		public String CustomTitleRecords { get; set; }

		public String ContentsRecords { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
