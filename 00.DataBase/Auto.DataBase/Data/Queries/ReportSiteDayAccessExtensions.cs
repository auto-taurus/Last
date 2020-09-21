using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class ReportSiteDayAccessExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.ReportSiteDayAccess GetByKey(this IQueryable<Auto.EFCore.Entities.ReportSiteDayAccess> queryable, int siteAccessId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.ReportSiteDayAccess> dbSet)
                return dbSet.Find(siteAccessId);

            return queryable.FirstOrDefault(q => q.SiteAccessId == siteAccessId);
        }

        public static ValueTask<Auto.EFCore.Entities.ReportSiteDayAccess> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.ReportSiteDayAccess> queryable, int siteAccessId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.ReportSiteDayAccess> dbSet)
                return dbSet.FindAsync(siteAccessId);

            var task = queryable.FirstOrDefaultAsync(q => q.SiteAccessId == siteAccessId);
            return new ValueTask<Auto.EFCore.Entities.ReportSiteDayAccess>(task);
        }

        #endregion

    }
}
