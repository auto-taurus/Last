using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class TaskNoviceLogExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.TaskNoviceLog GetByKey(this IQueryable<AutoNews.Data.Entities.TaskNoviceLog> queryable, int noviceLogId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.TaskNoviceLog> dbSet)
                return dbSet.Find(noviceLogId);

            return queryable.FirstOrDefault(q => q.NoviceLogId == noviceLogId);
        }

        public static ValueTask<AutoNews.Data.Entities.TaskNoviceLog> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.TaskNoviceLog> queryable, int noviceLogId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.TaskNoviceLog> dbSet)
                return dbSet.FindAsync(noviceLogId);

            var task = queryable.FirstOrDefaultAsync(q => q.NoviceLogId == noviceLogId);
            return new ValueTask<AutoNews.Data.Entities.TaskNoviceLog>(task);
        }

        #endregion

    }
}
