using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberFollowExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.MemberFollow GetByKey(this IQueryable<AutoNews.Data.Entities.MemberFollow> queryable, int followId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberFollow> dbSet)
                return dbSet.Find(followId);

            return queryable.FirstOrDefault(q => q.FollowId == followId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberFollow> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberFollow> queryable, int followId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberFollow> dbSet)
                return dbSet.FindAsync(followId);

            var task = queryable.FirstOrDefaultAsync(q => q.FollowId == followId);
            return new ValueTask<AutoNews.Data.Entities.MemberFollow>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.MemberFollow> ByMemberId(this IQueryable<AutoNews.Data.Entities.MemberFollow> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        #endregion

    }
}
