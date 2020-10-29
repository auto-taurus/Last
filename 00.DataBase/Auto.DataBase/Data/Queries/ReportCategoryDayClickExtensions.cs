using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class ReportCategoryDayClickExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.ReportCategoryDayClick GetByKey(this IQueryable<Master.Data.Entities.ReportCategoryDayClick> queryable, int categoryClickId)
        {
            if (queryable is DbSet<Master.Data.Entities.ReportCategoryDayClick> dbSet)
                return dbSet.Find(categoryClickId);

            return queryable.FirstOrDefault(q => q.CategoryClickId == categoryClickId);
        }

        public static ValueTask<Master.Data.Entities.ReportCategoryDayClick> GetByKeyAsync(this IQueryable<Master.Data.Entities.ReportCategoryDayClick> queryable, int categoryClickId)
        {
            if (queryable is DbSet<Master.Data.Entities.ReportCategoryDayClick> dbSet)
                return dbSet.FindAsync(categoryClickId);

            var task = queryable.FirstOrDefaultAsync(q => q.CategoryClickId == categoryClickId);
            return new ValueTask<Master.Data.Entities.ReportCategoryDayClick>(task);
        }

        #endregion

    }
}
