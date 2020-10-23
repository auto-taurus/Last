using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Entities.Modals {
    public partial class MemberCommentUp {
        public MemberCommentUp() {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int? CommentUpId { get; set; }

        public int? MemberId { get; set; }

        public int? CommentId { get; set; }
        #endregion

        #region Generated Relationships
        public virtual MemberComment MemberComment { get; set; }
        #endregion

    }
}
