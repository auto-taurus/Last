using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class WebSourceExtensions
    {
        #region Generated Extensions
        public static IQueryable<AutoNews.Data.Entities.WebSource> ByCategoryId(this IQueryable<AutoNews.Data.Entities.WebSource> queryable, int? categoryId)
        {
            return queryable.Where(q => (q.CategoryId == categoryId || (categoryId == null && q.CategoryId == null)));
        }

        public static AutoNews.Data.Entities.WebSource GetByKey(this IQueryable<AutoNews.Data.Entities.WebSource> queryable, int sourceId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebSource> dbSet)
                return dbSet.Find(sourceId);

            return queryable.FirstOrDefault(q => q.SourceId == sourceId);
        }

        public static ValueTask<AutoNews.Data.Entities.WebSource> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.WebSource> queryable, int sourceId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebSource> dbSet)
                return dbSet.FindAsync(sourceId);

            var task = queryable.FirstOrDefaultAsync(q => q.SourceId == sourceId);
            return new ValueTask<AutoNews.Data.Entities.WebSource>(task);
        }

        #endregion

    }
}
