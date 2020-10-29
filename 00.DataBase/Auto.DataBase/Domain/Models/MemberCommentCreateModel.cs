using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class MemberCommentCreateModel
    {
        #region Generated Properties
        public int CommentId { get; set; }

        public string NewsId { get; set; }

        public int? ParentId { get; set; }

        public int? MemberId { get; set; }

        public string MemberName { get; set; }

        public string CommentBody { get; set; }

        public DateTime? CommentTime { get; set; }

        public int? QuoteId { get; set; }

        public string QuoteName { get; set; }

        public int? Up { get; set; }

        public int? Number { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
