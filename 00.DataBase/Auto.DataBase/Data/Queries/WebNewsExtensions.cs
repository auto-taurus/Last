using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class WebNewsExtensions
    {
        #region Generated Extensions
        public static IQueryable<AutoNews.Data.Entities.WebNews> ByCategoryId(this IQueryable<AutoNews.Data.Entities.WebNews> queryable, int? categoryId)
        {
            return queryable.Where(q => (q.CategoryId == categoryId || (categoryId == null && q.CategoryId == null)));
        }

        public static AutoNews.Data.Entities.WebNews GetByKey(this IQueryable<AutoNews.Data.Entities.WebNews> queryable, string newsId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebNews> dbSet)
                return dbSet.Find(newsId);

            return queryable.FirstOrDefault(q => q.NewsId == newsId);
        }

        public static ValueTask<AutoNews.Data.Entities.WebNews> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.WebNews> queryable, string newsId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebNews> dbSet)
                return dbSet.FindAsync(newsId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsId == newsId);
            return new ValueTask<AutoNews.Data.Entities.WebNews>(task);
        }

        #endregion

    }
}
