using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class WebSiteExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.WebSite GetByKey(this IQueryable<Master.Data.Entities.WebSite> queryable, int siteId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebSite> dbSet)
                return dbSet.Find(siteId);

            return queryable.FirstOrDefault(q => q.SiteId == siteId);
        }

        public static ValueTask<Master.Data.Entities.WebSite> GetByKeyAsync(this IQueryable<Master.Data.Entities.WebSite> queryable, int siteId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebSite> dbSet)
                return dbSet.FindAsync(siteId);

            var task = queryable.FirstOrDefaultAsync(q => q.SiteId == siteId);
            return new ValueTask<Master.Data.Entities.WebSite>(task);
        }

        #endregion

    }
}
