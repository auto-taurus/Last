using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class WebSpecialExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.WebSpecial GetByKey(this IQueryable<Auto.EFCore.Entities.WebSpecial> queryable, int specialId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebSpecial> dbSet)
                return dbSet.Find(specialId);

            return queryable.FirstOrDefault(q => q.SpecialId == specialId);
        }

        public static ValueTask<Auto.EFCore.Entities.WebSpecial> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.WebSpecial> queryable, int specialId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebSpecial> dbSet)
                return dbSet.FindAsync(specialId);

            var task = queryable.FirstOrDefaultAsync(q => q.SpecialId == specialId);
            return new ValueTask<Auto.EFCore.Entities.WebSpecial>(task);
        }

        #endregion

    }
}
