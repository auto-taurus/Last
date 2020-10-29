using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class AutoBatchInsertNewsIdExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.AutoBatchInsertNewsId GetByKey(this IQueryable<Master.Data.Entities.AutoBatchInsertNewsId> queryable, int id)
        {
            if (queryable is DbSet<Master.Data.Entities.AutoBatchInsertNewsId> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Master.Data.Entities.AutoBatchInsertNewsId> GetByKeyAsync(this IQueryable<Master.Data.Entities.AutoBatchInsertNewsId> queryable, int id)
        {
            if (queryable is DbSet<Master.Data.Entities.AutoBatchInsertNewsId> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Master.Data.Entities.AutoBatchInsertNewsId>(task);
        }

        #endregion

    }
}
