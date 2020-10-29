using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberFollowExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.MemberFollow GetByKey(this IQueryable<Master.Data.Entities.MemberFollow> queryable, int followId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberFollow> dbSet)
                return dbSet.Find(followId);

            return queryable.FirstOrDefault(q => q.FollowId == followId);
        }

        public static ValueTask<Master.Data.Entities.MemberFollow> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberFollow> queryable, int followId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberFollow> dbSet)
                return dbSet.FindAsync(followId);

            var task = queryable.FirstOrDefaultAsync(q => q.FollowId == followId);
            return new ValueTask<Master.Data.Entities.MemberFollow>(task);
        }

        public static IQueryable<Master.Data.Entities.MemberFollow> ByMemberId(this IQueryable<Master.Data.Entities.MemberFollow> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        #endregion

    }
}
