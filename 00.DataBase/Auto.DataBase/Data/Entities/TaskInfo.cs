using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class TaskInfo
    {
        public TaskInfo()
        {
            #region Generated Constructor
            MemberIncomes = new HashSet<MemberIncome>();
            #endregion
        }

        #region Generated Properties
        public int TaskId { get; set; }

        public int? ParentId { get; set; }

        public string TaskCode { get; set; }

        public string RelatedTasks { get; set; }

        public string TaskName { get; set; }

        public string Desc { get; set; }

        public string Tips { get; set; }

        public string SaveDesc { get; set; }

        public int? CategoryDay { get; set; }

        public int? CategoryFixed { get; set; }

        public string Platform { get; set; }

        public int? Beans { get; set; }

        public int? FirstBeans { get; set; }

        public int? UpperNumber { get; set; }

        public int? UpperBeans { get; set; }

        public int? Seconds { get; set; }

        public string BeansText { get; set; }

        public int? IsRandom { get; set; }

        public int? RandomBefore { get; set; }

        public int? RandomeAfter { get; set; }

        public int? IsSubset { get; set; }

        public int? IsDisplay { get; set; }

        public int? IsTime { get; set; }

        public DateTime? BeforeTime { get; set; }

        public DateTime? AfterTime { get; set; }

        public int? EffectiveDay { get; set; }

        public int? Sequence { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<MemberIncome> MemberIncomes { get; set; }

        #endregion

    }
}
