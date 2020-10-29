using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class ReportCategoryDayAccessExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.ReportCategoryDayAccess GetByKey(this IQueryable<Master.Data.Entities.ReportCategoryDayAccess> queryable, int categoryAccessId)
        {
            if (queryable is DbSet<Master.Data.Entities.ReportCategoryDayAccess> dbSet)
                return dbSet.Find(categoryAccessId);

            return queryable.FirstOrDefault(q => q.CategoryAccessId == categoryAccessId);
        }

        public static ValueTask<Master.Data.Entities.ReportCategoryDayAccess> GetByKeyAsync(this IQueryable<Master.Data.Entities.ReportCategoryDayAccess> queryable, int categoryAccessId)
        {
            if (queryable is DbSet<Master.Data.Entities.ReportCategoryDayAccess> dbSet)
                return dbSet.FindAsync(categoryAccessId);

            var task = queryable.FirstOrDefaultAsync(q => q.CategoryAccessId == categoryAccessId);
            return new ValueTask<Master.Data.Entities.ReportCategoryDayAccess>(task);
        }

        #endregion

    }
}
