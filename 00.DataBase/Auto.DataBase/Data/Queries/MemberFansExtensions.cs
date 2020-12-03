using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberFansExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.MemberFans GetByKey(this IQueryable<AutoNews.Data.Entities.MemberFans> queryable, int fansId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberFans> dbSet)
                return dbSet.Find(fansId);

            return queryable.FirstOrDefault(q => q.FansId == fansId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberFans> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberFans> queryable, int fansId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberFans> dbSet)
                return dbSet.FindAsync(fansId);

            var task = queryable.FirstOrDefaultAsync(q => q.FansId == fansId);
            return new ValueTask<AutoNews.Data.Entities.MemberFans>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.MemberFans> ByMemberId(this IQueryable<AutoNews.Data.Entities.MemberFans> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        #endregion

    }
}
