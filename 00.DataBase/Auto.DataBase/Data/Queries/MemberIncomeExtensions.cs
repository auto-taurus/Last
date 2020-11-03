using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberIncomeExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.MemberIncome GetByKey(this IQueryable<AutoNews.Data.Entities.MemberIncome> queryable, int incomeId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberIncome> dbSet)
                return dbSet.Find(incomeId);

            return queryable.FirstOrDefault(q => q.IncomeId == incomeId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberIncome> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberIncome> queryable, int incomeId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberIncome> dbSet)
                return dbSet.FindAsync(incomeId);

            var task = queryable.FirstOrDefaultAsync(q => q.IncomeId == incomeId);
            return new ValueTask<AutoNews.Data.Entities.MemberIncome>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.MemberIncome> ByMemberId(this IQueryable<AutoNews.Data.Entities.MemberIncome> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        public static IQueryable<AutoNews.Data.Entities.MemberIncome> ByTaskId(this IQueryable<AutoNews.Data.Entities.MemberIncome> queryable, int? taskId)
        {
            return queryable.Where(q => (q.TaskId == taskId || (taskId == null && q.TaskId == null)));
        }

        #endregion

    }
}
