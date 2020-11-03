using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class MemberProblemUpdateModel
    {
        #region Generated Properties
        public int ProblemId { get; set; }

        public string Title { get; set; }

        public string Desc { get; set; }

        public int? Type { get; set; }

        public string Urls { get; set; }

        public int? IsHot { get; set; }

        public int? Sequence { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
