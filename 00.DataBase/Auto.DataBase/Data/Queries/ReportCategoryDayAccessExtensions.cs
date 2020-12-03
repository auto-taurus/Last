using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class ReportCategoryDayAccessExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.ReportCategoryDayAccess GetByKey(this IQueryable<AutoNews.Data.Entities.ReportCategoryDayAccess> queryable, int categoryAccessId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.ReportCategoryDayAccess> dbSet)
                return dbSet.Find(categoryAccessId);

            return queryable.FirstOrDefault(q => q.CategoryAccessId == categoryAccessId);
        }

        public static ValueTask<AutoNews.Data.Entities.ReportCategoryDayAccess> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.ReportCategoryDayAccess> queryable, int categoryAccessId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.ReportCategoryDayAccess> dbSet)
                return dbSet.FindAsync(categoryAccessId);

            var task = queryable.FirstOrDefaultAsync(q => q.CategoryAccessId == categoryAccessId);
            return new ValueTask<AutoNews.Data.Entities.ReportCategoryDayAccess>(task);
        }

        #endregion

    }
}
