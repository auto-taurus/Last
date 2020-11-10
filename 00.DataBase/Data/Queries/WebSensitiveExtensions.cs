using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class WebSensitiveExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.WebSensitive GetByKey(this IQueryable<AutoNews.Data.Entities.WebSensitive> queryable, int sensitiveId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebSensitive> dbSet)
                return dbSet.Find(sensitiveId);

            return queryable.FirstOrDefault(q => q.SensitiveId == sensitiveId);
        }

        public static ValueTask<AutoNews.Data.Entities.WebSensitive> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.WebSensitive> queryable, int sensitiveId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebSensitive> dbSet)
                return dbSet.FindAsync(sensitiveId);

            var task = queryable.FirstOrDefaultAsync(q => q.SensitiveId == sensitiveId);
            return new ValueTask<AutoNews.Data.Entities.WebSensitive>(task);
        }

        #endregion

    }
}
