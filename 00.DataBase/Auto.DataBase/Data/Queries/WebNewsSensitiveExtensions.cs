using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class WebNewsSensitiveExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.WebNewsSensitive GetByKey(this IQueryable<Master.Data.Entities.WebNewsSensitive> queryable, int newsSensitiveId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebNewsSensitive> dbSet)
                return dbSet.Find(newsSensitiveId);

            return queryable.FirstOrDefault(q => q.NewsSensitiveId == newsSensitiveId);
        }

        public static ValueTask<Master.Data.Entities.WebNewsSensitive> GetByKeyAsync(this IQueryable<Master.Data.Entities.WebNewsSensitive> queryable, int newsSensitiveId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebNewsSensitive> dbSet)
                return dbSet.FindAsync(newsSensitiveId);

            var task = queryable.FirstOrDefaultAsync(q => q.NewsSensitiveId == newsSensitiveId);
            return new ValueTask<Master.Data.Entities.WebNewsSensitive>(task);
        }

        #endregion

    }
}
