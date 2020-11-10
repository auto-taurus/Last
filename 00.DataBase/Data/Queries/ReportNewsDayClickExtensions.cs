using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class ReportNewsDayClickExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.ReportNewsDayClick GetByKey(this IQueryable<AutoNews.Data.Entities.ReportNewsDayClick> queryable, int newsClickId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.ReportNewsDayClick> dbSet)
                return dbSet.Find(newsClickId);

            return queryable.FirstOrDefault(q => q.NewsClickId == newsClickId);
        }

        public static ValueTask<AutoNews.Data.Entities.ReportNewsDayClick> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.ReportNewsDayClick> queryable, int newsClickId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.ReportNewsDayClick> dbSet)
                return dbSet.FindAsync(newsClickId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsClickId == newsClickId);
            return new ValueTask<AutoNews.Data.Entities.ReportNewsDayClick>(task);
        }

        #endregion

    }
}
