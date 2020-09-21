using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class ReportNewsDayAccessExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.ReportNewsDayAccess GetByKey(this IQueryable<Auto.EFCore.Entities.ReportNewsDayAccess> queryable, int newsAccessId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.ReportNewsDayAccess> dbSet)
                return dbSet.Find(newsAccessId);

            return queryable.FirstOrDefault(q => q.NewsAccessId == newsAccessId);
        }

        public static ValueTask<Auto.EFCore.Entities.ReportNewsDayAccess> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.ReportNewsDayAccess> queryable, int newsAccessId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.ReportNewsDayAccess> dbSet)
                return dbSet.FindAsync(newsAccessId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsAccessId == newsAccessId);
            return new ValueTask<Auto.EFCore.Entities.ReportNewsDayAccess>(task);
        }

        #endregion

    }
}
