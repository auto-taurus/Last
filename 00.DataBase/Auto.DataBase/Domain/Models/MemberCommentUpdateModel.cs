using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class MemberCommentUpdateModel
    {
        #region Generated Properties
        public int CommentId { get; set; }

        public string NewsId { get; set; }

        public int? ParentId { get; set; }

        public int? OCommentId { get; set; }

        public string OCommentName { get; set; }

        public string OCommentBody { get; set; }

        public int? TCommentId { get; set; }

        public string TCommentName { get; set; }

        public string TCommentBody { get; set; }

        public DateTime? CommentTime { get; set; }

        public int? QuoteId { get; set; }

        public string QuoteName { get; set; }

        public int? Up { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

    }
}
