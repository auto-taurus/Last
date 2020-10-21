using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class WebSiteExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.WebSite GetByKey(this IQueryable<AutoNews.Data.Entities.WebSite> queryable, int siteId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebSite> dbSet)
                return dbSet.Find(siteId);

            return queryable.FirstOrDefault(q => q.SiteId == siteId);
        }

        public static ValueTask<AutoNews.Data.Entities.WebSite> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.WebSite> queryable, int siteId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebSite> dbSet)
                return dbSet.FindAsync(siteId);

            var task = queryable.FirstOrDefaultAsync(q => q.SiteId == siteId);
            return new ValueTask<AutoNews.Data.Entities.WebSite>(task);
        }

        #endregion

    }
}
