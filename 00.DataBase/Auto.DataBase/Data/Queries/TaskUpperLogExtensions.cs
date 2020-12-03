using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class TaskUpperLogExtensions
    {
        #region Generated Extensions
        public static IQueryable<AutoNews.Data.Entities.TaskUpperLog> ByTaskId(this IQueryable<AutoNews.Data.Entities.TaskUpperLog> queryable, int? taskId)
        {
            return queryable.Where(q => (q.TaskId == taskId || (taskId == null && q.TaskId == null)));
        }

        public static AutoNews.Data.Entities.TaskUpperLog GetByKey(this IQueryable<AutoNews.Data.Entities.TaskUpperLog> queryable, int upperLogId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.TaskUpperLog> dbSet)
                return dbSet.Find(upperLogId);

            return queryable.FirstOrDefault(q => q.UpperLogId == upperLogId);
        }

        public static ValueTask<AutoNews.Data.Entities.TaskUpperLog> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.TaskUpperLog> queryable, int upperLogId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.TaskUpperLog> dbSet)
                return dbSet.FindAsync(upperLogId);

            var task = queryable.FirstOrDefaultAsync(q => q.UpperLogId == upperLogId);
            return new ValueTask<AutoNews.Data.Entities.TaskUpperLog>(task);
        }

        #endregion

    }
}
