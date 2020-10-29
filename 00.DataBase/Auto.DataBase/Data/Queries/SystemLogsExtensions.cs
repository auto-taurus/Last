using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class SystemLogsExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.SystemLogs GetByKey(this IQueryable<Master.Data.Entities.SystemLogs> queryable, int logsId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemLogs> dbSet)
                return dbSet.Find(logsId);

            return queryable.FirstOrDefault(q => q.LogsId == logsId);
        }

        public static ValueTask<Master.Data.Entities.SystemLogs> GetByKeyAsync(this IQueryable<Master.Data.Entities.SystemLogs> queryable, int logsId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemLogs> dbSet)
                return dbSet.FindAsync(logsId);

            var task = queryable.FirstOrDefaultAsync(q => q.LogsId == logsId);
            return new ValueTask<Master.Data.Entities.SystemLogs>(task);
        }

        #endregion

    }
}
