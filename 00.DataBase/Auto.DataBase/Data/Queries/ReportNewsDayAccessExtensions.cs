using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class ReportNewsDayAccessExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.ReportNewsDayAccess GetByKey(this IQueryable<Master.Data.Entities.ReportNewsDayAccess> queryable, int newsAccessId)
        {
            if (queryable is DbSet<Master.Data.Entities.ReportNewsDayAccess> dbSet)
                return dbSet.Find(newsAccessId);

            return queryable.FirstOrDefault(q => q.NewsAccessId == newsAccessId);
        }

        public static ValueTask<Master.Data.Entities.ReportNewsDayAccess> GetByKeyAsync(this IQueryable<Master.Data.Entities.ReportNewsDayAccess> queryable, int newsAccessId)
        {
            if (queryable is DbSet<Master.Data.Entities.ReportNewsDayAccess> dbSet)
                return dbSet.FindAsync(newsAccessId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsAccessId == newsAccessId);
            return new ValueTask<Master.Data.Entities.ReportNewsDayAccess>(task);
        }

        #endregion

    }
}
