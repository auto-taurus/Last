using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class TaskDetailsExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.TaskDetails GetByKey(this IQueryable<AutoNews.Data.Entities.TaskDetails> queryable, int taskDetailsId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.TaskDetails> dbSet)
                return dbSet.Find(taskDetailsId);

            return queryable.FirstOrDefault(q => q.TaskDetailsId == taskDetailsId);
        }

        public static ValueTask<AutoNews.Data.Entities.TaskDetails> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.TaskDetails> queryable, int taskDetailsId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.TaskDetails> dbSet)
                return dbSet.FindAsync(taskDetailsId);

            var task = queryable.FirstOrDefaultAsync(q => q.TaskDetailsId == taskDetailsId);
            return new ValueTask<AutoNews.Data.Entities.TaskDetails>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.TaskDetails> ByTaskId(this IQueryable<AutoNews.Data.Entities.TaskDetails> queryable, int? taskId)
        {
            return queryable.Where(q => (q.TaskId == taskId || (taskId == null && q.TaskId == null)));
        }

        #endregion

    }
}
