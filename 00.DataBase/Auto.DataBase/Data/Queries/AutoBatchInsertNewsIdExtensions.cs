using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class AutoBatchInsertNewsIdExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.AutoBatchInsertNewsId GetByKey(this IQueryable<AutoNews.Data.Entities.AutoBatchInsertNewsId> queryable, int id)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.AutoBatchInsertNewsId> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<AutoNews.Data.Entities.AutoBatchInsertNewsId> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.AutoBatchInsertNewsId> queryable, int id)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.AutoBatchInsertNewsId> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<AutoNews.Data.Entities.AutoBatchInsertNewsId>(task);
        }

        #endregion

    }
}
