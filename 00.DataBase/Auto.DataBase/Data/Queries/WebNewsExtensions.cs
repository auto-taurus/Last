using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class WebNewsExtensions
    {
        #region Generated Extensions
        public static IQueryable<Master.Data.Entities.WebNews> ByCategoryId(this IQueryable<Master.Data.Entities.WebNews> queryable, int? categoryId)
        {
            return queryable.Where(q => (q.CategoryId == categoryId || (categoryId == null && q.CategoryId == null)));
        }

        public static Master.Data.Entities.WebNews GetByKey(this IQueryable<Master.Data.Entities.WebNews> queryable, string newsId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebNews> dbSet)
                return dbSet.Find(newsId);

            return queryable.FirstOrDefault(q => q.NewsId == newsId);
        }

        public static ValueTask<Master.Data.Entities.WebNews> GetByKeyAsync(this IQueryable<Master.Data.Entities.WebNews> queryable, string newsId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebNews> dbSet)
                return dbSet.FindAsync(newsId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsId == newsId);
            return new ValueTask<Master.Data.Entities.WebNews>(task);
        }

        public static IQueryable<Master.Data.Entities.WebNews> BySourceId(this IQueryable<Master.Data.Entities.WebNews> queryable, int? sourceId)
        {
            return queryable.Where(q => (q.SourceId == sourceId || (sourceId == null && q.SourceId == null)));
        }

        #endregion

    }
}
