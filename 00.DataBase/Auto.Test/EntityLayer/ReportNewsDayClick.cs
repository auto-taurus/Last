using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class ReportNewsDayClick : IEntity
	{
		public ReportNewsDayClick()
		{
		}

		public ReportNewsDayClick(Int32? newsClickId)
		{
			NewsClickId = newsClickId;
		}

		public Int32? NewsClickId { get; set; }

		public Int32? NewsId { get; set; }

		public Int32? CategoryId { get; set; }

		public String CategoryName { get; set; }

		public Int32? SpecialCode { get; set; }

		public String SpecialName { get; set; }

		public Int32? Count { get; set; }

		public DateTime? Today { get; set; }

		public DateTime? LastUpdateTime { get; set; }
	}
}
