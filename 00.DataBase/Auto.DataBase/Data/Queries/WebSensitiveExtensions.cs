using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class WebSensitiveExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.WebSensitive GetByKey(this IQueryable<Master.Data.Entities.WebSensitive> queryable, int sensitiveId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebSensitive> dbSet)
                return dbSet.Find(sensitiveId);

            return queryable.FirstOrDefault(q => q.SensitiveId == sensitiveId);
        }

        public static ValueTask<Master.Data.Entities.WebSensitive> GetByKeyAsync(this IQueryable<Master.Data.Entities.WebSensitive> queryable, int sensitiveId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebSensitive> dbSet)
                return dbSet.FindAsync(sensitiveId);

            var task = queryable.FirstOrDefaultAsync(q => q.SensitiveId == sensitiveId);
            return new ValueTask<Master.Data.Entities.WebSensitive>(task);
        }

        #endregion

    }
}
