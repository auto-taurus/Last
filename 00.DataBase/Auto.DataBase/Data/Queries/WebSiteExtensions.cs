using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class WebSiteExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.WebSite GetByKey(this IQueryable<Auto.EFCore.Entities.WebSite> queryable, int siteId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebSite> dbSet)
                return dbSet.Find(siteId);

            return queryable.FirstOrDefault(q => q.SiteId == siteId);
        }

        public static ValueTask<Auto.EFCore.Entities.WebSite> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.WebSite> queryable, int siteId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebSite> dbSet)
                return dbSet.FindAsync(siteId);

            var task = queryable.FirstOrDefaultAsync(q => q.SiteId == siteId);
            return new ValueTask<Auto.EFCore.Entities.WebSite>(task);
        }

        #endregion

    }
}
