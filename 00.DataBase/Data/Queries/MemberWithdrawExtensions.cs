using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberWithdrawExtensions
    {
        #region Generated Extensions
        public static IQueryable<AutoNews.Data.Entities.MemberWithdraw> ByMemberId(this IQueryable<AutoNews.Data.Entities.MemberWithdraw> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        public static AutoNews.Data.Entities.MemberWithdraw GetByKey(this IQueryable<AutoNews.Data.Entities.MemberWithdraw> queryable, long withdrawId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberWithdraw> dbSet)
                return dbSet.Find(withdrawId);

            return queryable.FirstOrDefault(q => q.WithdrawId == withdrawId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberWithdraw> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberWithdraw> queryable, long withdrawId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberWithdraw> dbSet)
                return dbSet.FindAsync(withdrawId);

            var task = queryable.FirstOrDefaultAsync(q => q.WithdrawId == withdrawId);
            return new ValueTask<AutoNews.Data.Entities.MemberWithdraw>(task);
        }

        #endregion

    }
}
