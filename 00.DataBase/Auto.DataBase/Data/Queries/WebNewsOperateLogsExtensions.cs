using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class WebNewsOperateLogsExtensions
    {
        #region Generated Extensions
        public static IQueryable<Auto.EFCore.Entities.WebNewsOperateLogs> ByNewsId(this IQueryable<Auto.EFCore.Entities.WebNewsOperateLogs> queryable, int? newsId)
        {
            return queryable.Where(q => (q.NewsId == newsId || (newsId == null && q.NewsId == null)));
        }

        public static Auto.EFCore.Entities.WebNewsOperateLogs GetByKey(this IQueryable<Auto.EFCore.Entities.WebNewsOperateLogs> queryable, int newsOperateId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebNewsOperateLogs> dbSet)
                return dbSet.Find(newsOperateId);

            return queryable.FirstOrDefault(q => q.NewsOperateId == newsOperateId);
        }

        public static ValueTask<Auto.EFCore.Entities.WebNewsOperateLogs> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.WebNewsOperateLogs> queryable, int newsOperateId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebNewsOperateLogs> dbSet)
                return dbSet.FindAsync(newsOperateId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsOperateId == newsOperateId);
            return new ValueTask<Auto.EFCore.Entities.WebNewsOperateLogs>(task);
        }

        #endregion

    }
}
