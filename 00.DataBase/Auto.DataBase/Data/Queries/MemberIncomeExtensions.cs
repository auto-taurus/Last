using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberIncomeExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.MemberIncome GetByKey(this IQueryable<Master.Data.Entities.MemberIncome> queryable, int incomeId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberIncome> dbSet)
                return dbSet.Find(incomeId);

            return queryable.FirstOrDefault(q => q.IncomeId == incomeId);
        }

        public static ValueTask<Master.Data.Entities.MemberIncome> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberIncome> queryable, int incomeId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberIncome> dbSet)
                return dbSet.FindAsync(incomeId);

            var task = queryable.FirstOrDefaultAsync(q => q.IncomeId == incomeId);
            return new ValueTask<Master.Data.Entities.MemberIncome>(task);
        }

        public static IQueryable<Master.Data.Entities.MemberIncome> ByMemberId(this IQueryable<Master.Data.Entities.MemberIncome> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        #endregion

    }
}
