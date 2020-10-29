using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberWithdrawConfigExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.MemberWithdrawConfig GetByKey(this IQueryable<Master.Data.Entities.MemberWithdrawConfig> queryable, int withdrawConfigId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberWithdrawConfig> dbSet)
                return dbSet.Find(withdrawConfigId);

            return queryable.FirstOrDefault(q => q.WithdrawConfigId == withdrawConfigId);
        }

        public static ValueTask<Master.Data.Entities.MemberWithdrawConfig> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberWithdrawConfig> queryable, int withdrawConfigId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberWithdrawConfig> dbSet)
                return dbSet.FindAsync(withdrawConfigId);

            var task = queryable.FirstOrDefaultAsync(q => q.WithdrawConfigId == withdrawConfigId);
            return new ValueTask<Master.Data.Entities.MemberWithdrawConfig>(task);
        }

        #endregion

    }
}
