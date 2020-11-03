using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberCommentSensitiveExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.MemberCommentSensitive GetByKey(this IQueryable<AutoNews.Data.Entities.MemberCommentSensitive> queryable, int commentSensitiveId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberCommentSensitive> dbSet)
                return dbSet.Find(commentSensitiveId);

            return queryable.FirstOrDefault(q => q.CommentSensitiveId == commentSensitiveId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberCommentSensitive> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberCommentSensitive> queryable, int commentSensitiveId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberCommentSensitive> dbSet)
                return dbSet.FindAsync(commentSensitiveId);

            var task = queryable.FirstOrDefaultAsync(q => q.CommentSensitiveId == commentSensitiveId);
            return new ValueTask<AutoNews.Data.Entities.MemberCommentSensitive>(task);
        }

        #endregion

    }
}
