using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberTaskExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.MemberTask GetByKey(this IQueryable<AutoNews.Data.Entities.MemberTask> queryable, int taskId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberTask> dbSet)
                return dbSet.Find(taskId);

            return queryable.FirstOrDefault(q => q.TaskId == taskId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberTask> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberTask> queryable, int taskId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberTask> dbSet)
                return dbSet.FindAsync(taskId);

            var task = queryable.FirstOrDefaultAsync(q => q.TaskId == taskId);
            return new ValueTask<AutoNews.Data.Entities.MemberTask>(task);
        }

        #endregion

    }
}
