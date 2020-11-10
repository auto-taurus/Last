using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class TaskInfoUpdateModel
    {
        #region Generated Properties
        public int TaskId { get; set; }

        public string TaskCode { get; set; }

        public string RelatedTasks { get; set; }

        public string TaskName { get; set; }

        public string ShowDesc { get; set; }

        public string BeansText { get; set; }

        public string Tips { get; set; }

        public int? IconType { get; set; }

        public int? JumpType { get; set; }

        public string JumpTitle { get; set; }

        public string JumpUrl { get; set; }

        public int? CategoryDay { get; set; }

        public int? CategoryFixed { get; set; }

        public string Platform { get; set; }

        public int? IsNoviceTask { get; set; }

        public int? IsDisplay { get; set; }

        public int? MaxBeans { get; set; }

        public string MaxBeansDesc { get; set; }

        public int? IsRandom { get; set; }

        public int? FirstBeans { get; set; }

        public int? RandomBefore { get; set; }

        public int? RandomAfter { get; set; }

        public int? FixedBeans { get; set; }

        public int? Seconds { get; set; }

        public int? UpperSeconds { get; set; }

        public string UpperSecondsDesc { get; set; }

        public int? UpperCount { get; set; }

        public int? UpperNumber { get; set; }

        public int? UpperBeans { get; set; }

        public string UpperBeansDesc { get; set; }

        public int? IsTimeLimit { get; set; }

        public DateTime? BeforeTime { get; set; }

        public DateTime? AfterTime { get; set; }

        public int? Sequence { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
