using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class TaskInfoExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.TaskInfo GetByKey(this IQueryable<AutoNews.Data.Entities.TaskInfo> queryable, int taskId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.TaskInfo> dbSet)
                return dbSet.Find(taskId);

            return queryable.FirstOrDefault(q => q.TaskId == taskId);
        }

        public static ValueTask<AutoNews.Data.Entities.TaskInfo> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.TaskInfo> queryable, int taskId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.TaskInfo> dbSet)
                return dbSet.FindAsync(taskId);

            var task = queryable.FirstOrDefaultAsync(q => q.TaskId == taskId);
            return new ValueTask<AutoNews.Data.Entities.TaskInfo>(task);
        }

        #endregion

    }
}
