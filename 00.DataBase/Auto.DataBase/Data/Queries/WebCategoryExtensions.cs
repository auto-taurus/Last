using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class WebCategoryExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.WebCategory GetByKey(this IQueryable<Auto.EFCore.Entities.WebCategory> queryable, int categoryId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebCategory> dbSet)
                return dbSet.Find(categoryId);

            return queryable.FirstOrDefault(q => q.CategoryId == categoryId);
        }

        public static ValueTask<Auto.EFCore.Entities.WebCategory> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.WebCategory> queryable, int categoryId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebCategory> dbSet)
                return dbSet.FindAsync(categoryId);

            var task = queryable.FirstOrDefaultAsync(q => q.CategoryId == categoryId);
            return new ValueTask<Auto.EFCore.Entities.WebCategory>(task);
        }

        #endregion

    }
}
