using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class ReportCategoryDayClickExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.ReportCategoryDayClick GetByKey(this IQueryable<Auto.EFCore.Entities.ReportCategoryDayClick> queryable, int categoryClickId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.ReportCategoryDayClick> dbSet)
                return dbSet.Find(categoryClickId);

            return queryable.FirstOrDefault(q => q.CategoryClickId == categoryClickId);
        }

        public static ValueTask<Auto.EFCore.Entities.ReportCategoryDayClick> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.ReportCategoryDayClick> queryable, int categoryClickId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.ReportCategoryDayClick> dbSet)
                return dbSet.FindAsync(categoryClickId);

            var task = queryable.FirstOrDefaultAsync(q => q.CategoryClickId == categoryClickId);
            return new ValueTask<Auto.EFCore.Entities.ReportCategoryDayClick>(task);
        }

        #endregion

    }
}
