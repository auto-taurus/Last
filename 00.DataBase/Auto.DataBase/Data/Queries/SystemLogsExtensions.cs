using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemLogsExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.SystemLogs GetByKey(this IQueryable<Auto.EFCore.Entities.SystemLogs> queryable, int logsId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemLogs> dbSet)
                return dbSet.Find(logsId);

            return queryable.FirstOrDefault(q => q.LogsId == logsId);
        }

        public static ValueTask<Auto.EFCore.Entities.SystemLogs> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.SystemLogs> queryable, int logsId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemLogs> dbSet)
                return dbSet.FindAsync(logsId);

            var task = queryable.FirstOrDefaultAsync(q => q.LogsId == logsId);
            return new ValueTask<Auto.EFCore.Entities.SystemLogs>(task);
        }

        #endregion

    }
}
