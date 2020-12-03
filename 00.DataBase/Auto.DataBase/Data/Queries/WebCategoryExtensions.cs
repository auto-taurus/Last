using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class WebCategoryExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.WebCategory GetByKey(this IQueryable<AutoNews.Data.Entities.WebCategory> queryable, int categoryId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebCategory> dbSet)
                return dbSet.Find(categoryId);

            return queryable.FirstOrDefault(q => q.CategoryId == categoryId);
        }

        public static ValueTask<AutoNews.Data.Entities.WebCategory> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.WebCategory> queryable, int categoryId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebCategory> dbSet)
                return dbSet.FindAsync(categoryId);

            var task = queryable.FirstOrDefaultAsync(q => q.CategoryId == categoryId);
            return new ValueTask<AutoNews.Data.Entities.WebCategory>(task);
        }

        #endregion

    }
}
