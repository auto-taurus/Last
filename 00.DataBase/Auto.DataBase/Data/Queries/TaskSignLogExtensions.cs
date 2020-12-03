using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class TaskSignLogExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.TaskSignLog GetByKey(this IQueryable<AutoNews.Data.Entities.TaskSignLog> queryable, int signLogId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.TaskSignLog> dbSet)
                return dbSet.Find(signLogId);

            return queryable.FirstOrDefault(q => q.SignLogId == signLogId);
        }

        public static ValueTask<AutoNews.Data.Entities.TaskSignLog> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.TaskSignLog> queryable, int signLogId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.TaskSignLog> dbSet)
                return dbSet.FindAsync(signLogId);

            var task = queryable.FirstOrDefaultAsync(q => q.SignLogId == signLogId);
            return new ValueTask<AutoNews.Data.Entities.TaskSignLog>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.TaskSignLog> ByTaskId(this IQueryable<AutoNews.Data.Entities.TaskSignLog> queryable, int? taskId)
        {
            return queryable.Where(q => (q.TaskId == taskId || (taskId == null && q.TaskId == null)));
        }

        #endregion

    }
}
