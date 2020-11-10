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

        public static AutoNews.Data.Entities.MemberCommentUp GetByKey(this IQueryable<AutoNews.Data.Entities.MemberCommentUp> queryable, int commentUpId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberCommentUp> dbSet)
                return dbSet.Find(commentUpId);

            return queryable.FirstOrDefault(q => q.CommentUpId == commentUpId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberCommentUp> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberCommentUp> queryable, int commentUpId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberCommentUp> dbSet)
                return dbSet.FindAsync(commentUpId);

            var task = queryable.FirstOrDefaultAsync(q => q.CommentUpId == commentUpId);
            return new ValueTask<AutoNews.Data.Entities.MemberCommentUp>(task);
        }

        #endregion

    }
}
