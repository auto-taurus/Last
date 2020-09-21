using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class ReportNewsDayClickExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.ReportNewsDayClick GetByKey(this IQueryable<Auto.EFCore.Entities.ReportNewsDayClick> queryable, int newsClickId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.ReportNewsDayClick> dbSet)
                return dbSet.Find(newsClickId);

            return queryable.FirstOrDefault(q => q.NewsClickId == newsClickId);
        }

        public static ValueTask<Auto.EFCore.Entities.ReportNewsDayClick> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.ReportNewsDayClick> queryable, int newsClickId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.ReportNewsDayClick> dbSet)
                return dbSet.FindAsync(newsClickId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsClickId == newsClickId);
            return new ValueTask<Auto.EFCore.Entities.ReportNewsDayClick>(task);
        }

        #endregion

    }
}
