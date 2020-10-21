using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class MemberProblem
    {
        public MemberProblem()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int ProblemId { get; set; }

        public string Title { get; set; }

        public string Desc { get; set; }

        public int? Type { get; set; }

        public string Urls { get; set; }

        public int? IsHot { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
