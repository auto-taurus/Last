using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class TaskInfoExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.TaskInfo GetByKey(this IQueryable<Master.Data.Entities.TaskInfo> queryable, int taskId)
        {
            if (queryable is DbSet<Master.Data.Entities.TaskInfo> dbSet)
                return dbSet.Find(taskId);

            return queryable.FirstOrDefault(q => q.TaskId == taskId);
        }

        public static ValueTask<Master.Data.Entities.TaskInfo> GetByKeyAsync(this IQueryable<Master.Data.Entities.TaskInfo> queryable, int taskId)
        {
            if (queryable is DbSet<Master.Data.Entities.TaskInfo> dbSet)
                return dbSet.FindAsync(taskId);

            var task = queryable.FirstOrDefaultAsync(q => q.TaskId == taskId);
            return new ValueTask<Master.Data.Entities.TaskInfo>(task);
        }

        #endregion

    }
}
