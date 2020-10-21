using System;
using System.Collections.Generic;

namespace Auto.Entities.Modals {
    public partial class MemberCommentSensitive
    {
        public MemberCommentSensitive()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int CommentSensitiveId { get; set; }

        public string SensitiveWords { get; set; }

        public string ReplaceValue { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
