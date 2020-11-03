using System;
using System.Collections.ObjectModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class TaskInfo : IEntity
	{
		public TaskInfo()
		{
		}

		public TaskInfo(Int32? taskId)
		{
			TaskId = taskId;
		}

		public Int32? TaskId { get; set; }

		public String TaskCode { get; set; }

		public String RelatedTasks { get; set; }

		public String TaskName { get; set; }

		public String Desc { get; set; }

		public String SaveDesc { get; set; }

		public Int32? CategoryDay { get; set; }

		public Int32? CategoryFixed { get; set; }

		public String Platform { get; set; }

		public Int64? Beans { get; set; }

		public String BeansText { get; set; }

		public Int32? IsDisplay { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }

		public Collection<MemberIncome> MemberIncomes { get; set; }
	}
}
