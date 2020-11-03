using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class ReportNewsDayAccessExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.ReportNewsDayAccess GetByKey(this IQueryable<AutoNews.Data.Entities.ReportNewsDayAccess> queryable, int newsAccessId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.ReportNewsDayAccess> dbSet)
                return dbSet.Find(newsAccessId);

            return queryable.FirstOrDefault(q => q.NewsAccessId == newsAccessId);
        }

        public static ValueTask<AutoNews.Data.Entities.ReportNewsDayAccess> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.ReportNewsDayAccess> queryable, int newsAccessId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.ReportNewsDayAccess> dbSet)
                return dbSet.FindAsync(newsAccessId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsAccessId == newsAccessId);
            return new ValueTask<AutoNews.Data.Entities.ReportNewsDayAccess>(task);
        }

        #endregion

    }
}
