using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class WebNewsOperateLogsExtensions
    {
        #region Generated Extensions
        public static IQueryable<Master.Data.Entities.WebNewsOperateLogs> ByNewsId(this IQueryable<Master.Data.Entities.WebNewsOperateLogs> queryable, string newsId)
        {
            return queryable.Where(q => (q.NewsId == newsId || (newsId == null && q.NewsId == null)));
        }

        public static Master.Data.Entities.WebNewsOperateLogs GetByKey(this IQueryable<Master.Data.Entities.WebNewsOperateLogs> queryable, int newsOperateId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebNewsOperateLogs> dbSet)
                return dbSet.Find(newsOperateId);

            return queryable.FirstOrDefault(q => q.NewsOperateId == newsOperateId);
        }

        public static ValueTask<Master.Data.Entities.WebNewsOperateLogs> GetByKeyAsync(this IQueryable<Master.Data.Entities.WebNewsOperateLogs> queryable, int newsOperateId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebNewsOperateLogs> dbSet)
                return dbSet.FindAsync(newsOperateId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsOperateId == newsOperateId);
            return new ValueTask<Master.Data.Entities.WebNewsOperateLogs>(task);
        }

        #endregion

    }
}
