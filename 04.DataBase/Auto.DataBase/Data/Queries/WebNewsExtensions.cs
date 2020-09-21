using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class WebNewsExtensions
    {
        #region Generated Extensions
        public static IQueryable<Auto.EFCore.Entities.WebNews> ByCategoryId(this IQueryable<Auto.EFCore.Entities.WebNews> queryable, int? categoryId)
        {
            return queryable.Where(q => (q.CategoryId == categoryId || (categoryId == null && q.CategoryId == null)));
        }

        public static Auto.EFCore.Entities.WebNews GetByKey(this IQueryable<Auto.EFCore.Entities.WebNews> queryable, int newsId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebNews> dbSet)
                return dbSet.Find(newsId);

            return queryable.FirstOrDefault(q => q.NewsId == newsId);
        }

        public static ValueTask<Auto.EFCore.Entities.WebNews> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.WebNews> queryable, int newsId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebNews> dbSet)
                return dbSet.FindAsync(newsId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsId == newsId);
            return new ValueTask<Auto.EFCore.Entities.WebNews>(task);
        }

        #endregion

    }
}
