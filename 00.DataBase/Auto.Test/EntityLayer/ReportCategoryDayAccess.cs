using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class ReportCategoryDayAccess : IEntity
	{
		public ReportCategoryDayAccess()
		{
		}

		public ReportCategoryDayAccess(Int32? categoryAccessId)
		{
			CategoryAccessId = categoryAccessId;
		}

		public Int32? CategoryAccessId { get; set; }

		public Int32? CategoryId { get; set; }

		public String CategoryName { get; set; }

		public Int32? Count { get; set; }

		public DateTime? Today { get; set; }

		public DateTime? LastUpdateTime { get; set; }
	}
}
