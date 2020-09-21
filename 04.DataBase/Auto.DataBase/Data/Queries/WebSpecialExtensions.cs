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
        public static Auto.EFCore.Entities.WebSpecial GetByKey(this IQueryable<Auto.EFCore.Entities.WebSpecial> queryable, int specialId, string specialCode)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebSpecial> dbSet)
                return dbSet.Find(specialId, specialCode);

            return queryable.FirstOrDefault(q => q.SpecialId == specialId
                && q.SpecialCode == specialCode);
        }

        public static ValueTask<Auto.EFCore.Entities.WebSpecial> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.WebSpecial> queryable, int specialId, string specialCode)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebSpecial> dbSet)
                return dbSet.FindAsync(specialId, specialCode);

            var task = queryable.FirstOrDefaultAsync(q => q.SpecialId == specialId
                && q.SpecialCode == specialCode);
            return new ValueTask<Auto.EFCore.Entities.WebSpecial>(task);
        }

        #endregion

    }
}
