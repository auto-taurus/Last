using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberCommentSensitiveExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.MemberCommentSensitive GetByKey(this IQueryable<Master.Data.Entities.MemberCommentSensitive> queryable, int commentSensitiveId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberCommentSensitive> dbSet)
                return dbSet.Find(commentSensitiveId);

            return queryable.FirstOrDefault(q => q.CommentSensitiveId == commentSensitiveId);
        }

        public static ValueTask<Master.Data.Entities.MemberCommentSensitive> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberCommentSensitive> queryable, int commentSensitiveId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberCommentSensitive> dbSet)
                return dbSet.FindAsync(commentSensitiveId);

            var task = queryable.FirstOrDefaultAsync(q => q.CommentSensitiveId == commentSensitiveId);
            return new ValueTask<Master.Data.Entities.MemberCommentSensitive>(task);
        }

        #endregion

    }
}
