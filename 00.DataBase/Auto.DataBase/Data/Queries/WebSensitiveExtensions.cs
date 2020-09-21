using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class WebSensitiveExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.WebSensitive GetByKey(this IQueryable<Auto.EFCore.Entities.WebSensitive> queryable, int sensitiveId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebSensitive> dbSet)
                return dbSet.Find(sensitiveId);

            return queryable.FirstOrDefault(q => q.SensitiveId == sensitiveId);
        }

        public static ValueTask<Auto.EFCore.Entities.WebSensitive> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.WebSensitive> queryable, int sensitiveId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebSensitive> dbSet)
                return dbSet.FindAsync(sensitiveId);

            var task = queryable.FirstOrDefaultAsync(q => q.SensitiveId == sensitiveId);
            return new ValueTask<Auto.EFCore.Entities.WebSensitive>(task);
        }

        #endregion

    }
}
