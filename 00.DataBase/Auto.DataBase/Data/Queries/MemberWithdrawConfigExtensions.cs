using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberWithdrawConfigExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.MemberWithdrawConfig GetByKey(this IQueryable<AutoNews.Data.Entities.MemberWithdrawConfig> queryable, int withdrawConfigId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberWithdrawConfig> dbSet)
                return dbSet.Find(withdrawConfigId);

            return queryable.FirstOrDefault(q => q.WithdrawConfigId == withdrawConfigId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberWithdrawConfig> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberWithdrawConfig> queryable, int withdrawConfigId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberWithdrawConfig> dbSet)
                return dbSet.FindAsync(withdrawConfigId);

            var task = queryable.FirstOrDefaultAsync(q => q.WithdrawConfigId == withdrawConfigId);
            return new ValueTask<AutoNews.Data.Entities.MemberWithdrawConfig>(task);
        }

        #endregion

    }
}
