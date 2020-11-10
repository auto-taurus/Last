using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class WebSpecialExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.WebSpecial GetByKey(this IQueryable<AutoNews.Data.Entities.WebSpecial> queryable, int specialId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebSpecial> dbSet)
                return dbSet.Find(specialId);

            return queryable.FirstOrDefault(q => q.SpecialId == specialId);
        }

        public static ValueTask<AutoNews.Data.Entities.WebSpecial> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.WebSpecial> queryable, int specialId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebSpecial> dbSet)
                return dbSet.FindAsync(specialId);

            var task = queryable.FirstOrDefaultAsync(q => q.SpecialId == specialId);
            return new ValueTask<AutoNews.Data.Entities.WebSpecial>(task);
        }

        #endregion

    }
}
