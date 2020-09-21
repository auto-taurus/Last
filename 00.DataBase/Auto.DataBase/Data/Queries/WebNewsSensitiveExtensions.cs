using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class WebNewsSensitiveExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.WebNewsSensitive GetByKey(this IQueryable<Auto.EFCore.Entities.WebNewsSensitive> queryable, int newsSensitiveId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebNewsSensitive> dbSet)
                return dbSet.Find(newsSensitiveId);

            return queryable.FirstOrDefault(q => q.NewsSensitiveId == newsSensitiveId);
        }

        public static ValueTask<Auto.EFCore.Entities.WebNewsSensitive> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.WebNewsSensitive> queryable, int newsSensitiveId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebNewsSensitive> dbSet)
                return dbSet.FindAsync(newsSensitiveId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsSensitiveId == newsSensitiveId);
            return new ValueTask<Auto.EFCore.Entities.WebNewsSensitive>(task);
        }

        #endregion

    }
}
