using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberWithdrawExtensions
    {
        #region Generated Extensions
        public static IQueryable<Master.Data.Entities.MemberWithdraw> ByMemberId(this IQueryable<Master.Data.Entities.MemberWithdraw> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        public static Master.Data.Entities.MemberWithdraw GetByKey(this IQueryable<Master.Data.Entities.MemberWithdraw> queryable, long withdrawId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberWithdraw> dbSet)
                return dbSet.Find(withdrawId);

            return queryable.FirstOrDefault(q => q.WithdrawId == withdrawId);
        }

        public static ValueTask<Master.Data.Entities.MemberWithdraw> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberWithdraw> queryable, long withdrawId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberWithdraw> dbSet)
                return dbSet.FindAsync(withdrawId);

            var task = queryable.FirstOrDefaultAsync(q => q.WithdrawId == withdrawId);
            return new ValueTask<Master.Data.Entities.MemberWithdraw>(task);
        }

        #endregion

    }
}
