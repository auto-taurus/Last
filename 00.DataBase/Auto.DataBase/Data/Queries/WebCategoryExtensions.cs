using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class WebCategoryExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.WebCategory GetByKey(this IQueryable<Master.Data.Entities.WebCategory> queryable, int categoryId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebCategory> dbSet)
                return dbSet.Find(categoryId);

            return queryable.FirstOrDefault(q => q.CategoryId == categoryId);
        }

        public static ValueTask<Master.Data.Entities.WebCategory> GetByKeyAsync(this IQueryable<Master.Data.Entities.WebCategory> queryable, int categoryId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebCategory> dbSet)
                return dbSet.FindAsync(categoryId);

            var task = queryable.FirstOrDefaultAsync(q => q.CategoryId == categoryId);
            return new ValueTask<Master.Data.Entities.WebCategory>(task);
        }

        #endregion

    }
}
