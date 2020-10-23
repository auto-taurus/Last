using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberCommentUpExtensions
    {
        #region Generated Extensions
        public static IQueryable<AutoNews.Data.Entities.MemberCommentUp> ByCommentId(this IQueryable<AutoNews.Data.Entities.MemberCommentUp> queryable, int? commentId)
        {
            return queryable.Where(q => (q.CommentId == commentId || (commentId == null && q.CommentId == null)));
        }

        #endregion

    }
}
