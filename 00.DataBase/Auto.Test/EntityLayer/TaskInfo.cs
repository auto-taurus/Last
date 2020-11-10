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

		public Int32? ParentId { get; set; }

		public String TaskCode { get; set; }

		public String RelatedTasks { get; set; }

		public String TaskName { get; set; }

		public String Desc { get; set; }

		public String Tips { get; set; }

		public String SaveDesc { get; set; }

		public Int32? CategoryDay { get; set; }

		public Int32? CategoryFixed { get; set; }

		public String Platform { get; set; }

		public Int32? Beans { get; set; }

		public Int32? FirstBeans { get; set; }

		public Int32? UpperNumber { get; set; }

		public Int32? UpperBeans { get; set; }

		public Int32? Seconds { get; set; }

		public Int32? UpperSeconds { get; set; }

		public String BeansText { get; set; }

		public Int32? IsRandom { get; set; }

		public Int32? RandomBefore { get; set; }

		public Int32? RandomAfter { get; set; }

		public Int32? IsSubset { get; set; }

		public Int32? IsDisplay { get; set; }

		public Int32? IsTime { get; set; }

		public DateTime? BeforeTime { get; set; }

		public DateTime? AfterTime { get; set; }

		public Int32? EffectiveDay { get; set; }

		public Int32? IconType { get; set; }

		public Int32? JumpType { get; set; }

		public String JumpTitle { get; set; }

		public String JumpUrl { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }

		public Collection<MemberIncome> MemberIncomes { get; set; }
	}
}
