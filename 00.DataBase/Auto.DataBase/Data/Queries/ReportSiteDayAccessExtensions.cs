using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class ReportSiteDayAccessExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.ReportSiteDayAccess GetByKey(this IQueryable<AutoNews.Data.Entities.ReportSiteDayAccess> queryable, int siteAccessId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.ReportSiteDayAccess> dbSet)
                return dbSet.Find(siteAccessId);

            return queryable.FirstOrDefault(q => q.SiteAccessId == siteAccessId);
        }

        public static ValueTask<AutoNews.Data.Entities.ReportSiteDayAccess> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.ReportSiteDayAccess> queryable, int siteAccessId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.ReportSiteDayAccess> dbSet)
                return dbSet.FindAsync(siteAccessId);

            var task = queryable.FirstOrDefaultAsync(q => q.SiteAccessId == siteAccessId);
            return new ValueTask<AutoNews.Data.Entities.ReportSiteDayAccess>(task);
        }

        #endregion

    }
}
