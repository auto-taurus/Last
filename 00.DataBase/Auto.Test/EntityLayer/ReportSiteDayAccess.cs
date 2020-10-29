using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class ReportSiteDayAccess : IEntity
	{
		public ReportSiteDayAccess()
		{
		}

		public ReportSiteDayAccess(Int32? siteAccessId)
		{
			SiteAccessId = siteAccessId;
		}

		public Int32? SiteAccessId { get; set; }

		public Int32? SiteId { get; set; }

		public Int32? Count { get; set; }

		public DateTime? Today { get; set; }

		public DateTime? LastUpdateTime { get; set; }
	}
}
