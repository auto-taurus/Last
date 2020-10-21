using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class ReportNewsDayAccess : IEntity
	{
		public ReportNewsDayAccess()
		{
		}

		public ReportNewsDayAccess(Int32? newsAccessId)
		{
			NewsAccessId = newsAccessId;
		}

		public Int32? NewsAccessId { get; set; }

		public String NewsId { get; set; }

		public Int32? CategoryId { get; set; }

		public String CategoryName { get; set; }

		public Int32? SpecialCode { get; set; }

		public String SpecialName { get; set; }

		public Int32? Count { get; set; }

		public DateTime? Today { get; set; }

		public DateTime? LastUpdateTime { get; set; }
	}
}
