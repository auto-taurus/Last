using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class ReportCategoryDayClickExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.ReportCategoryDayClick GetByKey(this IQueryable<AutoNews.Data.Entities.ReportCategoryDayClick> queryable, int categoryClickId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.ReportCategoryDayClick> dbSet)
                return dbSet.Find(categoryClickId);

            return queryable.FirstOrDefault(q => q.CategoryClickId == categoryClickId);
        }

        public static ValueTask<AutoNews.Data.Entities.ReportCategoryDayClick> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.ReportCategoryDayClick> queryable, int categoryClickId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.ReportCategoryDayClick> dbSet)
                return dbSet.FindAsync(categoryClickId);

            var task = queryable.FirstOrDefaultAsync(q => q.CategoryClickId == categoryClickId);
            return new ValueTask<AutoNews.Data.Entities.ReportCategoryDayClick>(task);
        }

        #endregion

    }
}
