using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class AppInfoExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.AppInfo GetByKey(this IQueryable<AutoNews.Data.Entities.AppInfo> queryable, int appId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.AppInfo> dbSet)
                return dbSet.Find(appId);

            return queryable.FirstOrDefault(q => q.AppId == appId);
        }

        public static ValueTask<AutoNews.Data.Entities.AppInfo> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.AppInfo> queryable, int appId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.AppInfo> dbSet)
                return dbSet.FindAsync(appId);

            var task = queryable.FirstOrDefaultAsync(q => q.AppId == appId);
            return new ValueTask<AutoNews.Data.Entities.AppInfo>(task);
        }

        #endregion

    }
}
