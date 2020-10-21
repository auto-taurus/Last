using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class ReportCategoryDayClick : IEntity
	{
		public ReportCategoryDayClick()
		{
		}

		public ReportCategoryDayClick(Int32? categoryClickId)
		{
			CategoryClickId = categoryClickId;
		}

		public Int32? CategoryClickId { get; set; }

		public Int32? CategoryId { get; set; }

		public String CategoryName { get; set; }

		public Int32? Count { get; set; }

		public DateTime? Today { get; set; }

		public DateTime? LastUpdateTime { get; set; }
	}
}
