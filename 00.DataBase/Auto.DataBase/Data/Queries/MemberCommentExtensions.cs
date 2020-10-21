using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberCommentExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.MemberComment GetByKey(this IQueryable<AutoNews.Data.Entities.MemberComment> queryable, int commentId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberComment> dbSet)
                return dbSet.Find(commentId);

            return queryable.FirstOrDefault(q => q.CommentId == commentId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberComment> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberComment> queryable, int commentId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberComment> dbSet)
                return dbSet.FindAsync(commentId);

            var task = queryable.FirstOrDefaultAsync(q => q.CommentId == commentId);
            return new ValueTask<AutoNews.Data.Entities.MemberComment>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.MemberComment> ByNewsId(this IQueryable<AutoNews.Data.Entities.MemberComment> queryable, string newsId)
        {
            return queryable.Where(q => (q.NewsId == newsId || (newsId == null && q.NewsId == null)));
        }

        #endregion

    }
}
