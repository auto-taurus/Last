using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class WebSpecialExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.WebSpecial GetByKey(this IQueryable<Master.Data.Entities.WebSpecial> queryable, int specialId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebSpecial> dbSet)
                return dbSet.Find(specialId);

            return queryable.FirstOrDefault(q => q.SpecialId == specialId);
        }

        public static ValueTask<Master.Data.Entities.WebSpecial> GetByKeyAsync(this IQueryable<Master.Data.Entities.WebSpecial> queryable, int specialId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebSpecial> dbSet)
                return dbSet.FindAsync(specialId);

            var task = queryable.FirstOrDefaultAsync(q => q.SpecialId == specialId);
            return new ValueTask<Master.Data.Entities.WebSpecial>(task);
        }

        #endregion

    }
}
