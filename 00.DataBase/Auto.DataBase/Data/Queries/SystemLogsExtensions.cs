using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class SystemLogsExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.SystemLogs GetByKey(this IQueryable<AutoNews.Data.Entities.SystemLogs> queryable, int logsId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemLogs> dbSet)
                return dbSet.Find(logsId);

            return queryable.FirstOrDefault(q => q.LogsId == logsId);
        }

        public static ValueTask<AutoNews.Data.Entities.SystemLogs> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.SystemLogs> queryable, int logsId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemLogs> dbSet)
                return dbSet.FindAsync(logsId);

            var task = queryable.FirstOrDefaultAsync(q => q.LogsId == logsId);
            return new ValueTask<AutoNews.Data.Entities.SystemLogs>(task);
        }

        #endregion

    }
}
