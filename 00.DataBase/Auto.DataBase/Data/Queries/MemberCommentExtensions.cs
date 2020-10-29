using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberCommentExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.MemberComment GetByKey(this IQueryable<Master.Data.Entities.MemberComment> queryable, int commentId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberComment> dbSet)
                return dbSet.Find(commentId);

            return queryable.FirstOrDefault(q => q.CommentId == commentId);
        }

        public static ValueTask<Master.Data.Entities.MemberComment> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberComment> queryable, int commentId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberComment> dbSet)
                return dbSet.FindAsync(commentId);

            var task = queryable.FirstOrDefaultAsync(q => q.CommentId == commentId);
            return new ValueTask<Master.Data.Entities.MemberComment>(task);
        }

        public static IQueryable<Master.Data.Entities.MemberComment> ByMemberId(this IQueryable<Master.Data.Entities.MemberComment> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        public static IQueryable<Master.Data.Entities.MemberComment> ByNewsId(this IQueryable<Master.Data.Entities.MemberComment> queryable, string newsId)
        {
            return queryable.Where(q => (q.NewsId == newsId || (newsId == null && q.NewsId == null)));
        }

        #endregion

    }
}
