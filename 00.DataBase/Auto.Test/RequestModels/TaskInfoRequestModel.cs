using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class TaskInfoRequestModel
	{
		[Key]
		public Int32? TaskId { get; set; }

		public Int32? ParentId { get; set; }

		[StringLength(5)]
		public String TaskCode { get; set; }

		[StringLength(50)]
		public String RelatedTasks { get; set; }

		[StringLength(40)]
		public String TaskName { get; set; }

		[StringLength(100)]
		public String Desc { get; set; }

		[StringLength(100)]
		public String Tips { get; set; }

		[StringLength(200)]
		public String SaveDesc { get; set; }

		public Int32? CategoryDay { get; set; }

		public Int32? CategoryFixed { get; set; }

		[StringLength(20)]
		public String Platform { get; set; }

		public Int32? Beans { get; set; }

		public Int32? FirstBeans { get; set; }

		public Int32? UpperNumber { get; set; }

		public Int32? UpperBeans { get; set; }

		public Int32? Seconds { get; set; }

		public Int32? UpperSeconds { get; set; }

		[StringLength(40)]
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

		[StringLength(200)]
		public String JumpTitle { get; set; }

		[StringLength(510)]
		public String JumpUrl { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
