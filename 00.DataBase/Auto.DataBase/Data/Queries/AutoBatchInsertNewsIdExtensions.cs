using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class AutoBatchInsertNewsIdExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.AutoBatchInsertNewsId GetByKey(this IQueryable<Auto.EFCore.Entities.AutoBatchInsertNewsId> queryable, int id)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.AutoBatchInsertNewsId> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Auto.EFCore.Entities.AutoBatchInsertNewsId> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.AutoBatchInsertNewsId> queryable, int id)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.AutoBatchInsertNewsId> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Auto.EFCore.Entities.AutoBatchInsertNewsId>(task);
        }

        #endregion

    }
}
