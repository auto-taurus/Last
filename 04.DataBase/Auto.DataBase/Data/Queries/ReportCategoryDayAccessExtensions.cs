using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class ReportCategoryDayAccessExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.ReportCategoryDayAccess GetByKey(this IQueryable<Auto.EFCore.Entities.ReportCategoryDayAccess> queryable, int categoryAccessId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.ReportCategoryDayAccess> dbSet)
                return dbSet.Find(categoryAccessId);

            return queryable.FirstOrDefault(q => q.CategoryAccessId == categoryAccessId);
        }

        public static ValueTask<Auto.EFCore.Entities.ReportCategoryDayAccess> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.ReportCategoryDayAccess> queryable, int categoryAccessId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.ReportCategoryDayAccess> dbSet)
                return dbSet.FindAsync(categoryAccessId);

            var task = queryable.FirstOrDefaultAsync(q => q.CategoryAccessId == categoryAccessId);
            return new ValueTask<Auto.EFCore.Entities.ReportCategoryDayAccess>(task);
        }

        #endregion

    }
}
