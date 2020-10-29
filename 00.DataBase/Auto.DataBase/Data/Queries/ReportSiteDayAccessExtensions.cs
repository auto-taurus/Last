using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class ReportSiteDayAccessExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.ReportSiteDayAccess GetByKey(this IQueryable<Master.Data.Entities.ReportSiteDayAccess> queryable, int siteAccessId)
        {
            if (queryable is DbSet<Master.Data.Entities.ReportSiteDayAccess> dbSet)
                return dbSet.Find(siteAccessId);

            return queryable.FirstOrDefault(q => q.SiteAccessId == siteAccessId);
        }

        public static ValueTask<Master.Data.Entities.ReportSiteDayAccess> GetByKeyAsync(this IQueryable<Master.Data.Entities.ReportSiteDayAccess> queryable, int siteAccessId)
        {
            if (queryable is DbSet<Master.Data.Entities.ReportSiteDayAccess> dbSet)
                return dbSet.FindAsync(siteAccessId);

            var task = queryable.FirstOrDefaultAsync(q => q.SiteAccessId == siteAccessId);
            return new ValueTask<Master.Data.Entities.ReportSiteDayAccess>(task);
        }

        #endregion

    }
}
