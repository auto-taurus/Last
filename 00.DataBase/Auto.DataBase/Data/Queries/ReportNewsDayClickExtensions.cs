using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class ReportNewsDayClickExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.ReportNewsDayClick GetByKey(this IQueryable<Master.Data.Entities.ReportNewsDayClick> queryable, int newsClickId)
        {
            if (queryable is DbSet<Master.Data.Entities.ReportNewsDayClick> dbSet)
                return dbSet.Find(newsClickId);

            return queryable.FirstOrDefault(q => q.NewsClickId == newsClickId);
        }

        public static ValueTask<Master.Data.Entities.ReportNewsDayClick> GetByKeyAsync(this IQueryable<Master.Data.Entities.ReportNewsDayClick> queryable, int newsClickId)
        {
            if (queryable is DbSet<Master.Data.Entities.ReportNewsDayClick> dbSet)
                return dbSet.FindAsync(newsClickId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsClickId == newsClickId);
            return new ValueTask<Master.Data.Entities.ReportNewsDayClick>(task);
        }

        #endregion

    }
}
