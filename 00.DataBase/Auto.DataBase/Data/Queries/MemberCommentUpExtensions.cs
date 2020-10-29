using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberCommentUpExtensions
    {
        #region Generated Extensions
        public static IQueryable<Master.Data.Entities.MemberCommentUp> ByCommentId(this IQueryable<Master.Data.Entities.MemberCommentUp> queryable, int? commentId)
        {
            return queryable.Where(q => (q.CommentId == commentId || (commentId == null && q.CommentId == null)));
        }

        public static Master.Data.Entities.MemberCommentUp GetByKey(this IQueryable<Master.Data.Entities.MemberCommentUp> queryable, int commentUpId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberCommentUp> dbSet)
                return dbSet.Find(commentUpId);

            return queryable.FirstOrDefault(q => q.CommentUpId == commentUpId);
        }

        public static ValueTask<Master.Data.Entities.MemberCommentUp> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberCommentUp> queryable, int commentUpId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberCommentUp> dbSet)
                return dbSet.FindAsync(commentUpId);

            var task = queryable.FirstOrDefaultAsync(q => q.CommentUpId == commentUpId);
            return new ValueTask<Master.Data.Entities.MemberCommentUp>(task);
        }

        #endregion

    }
}
