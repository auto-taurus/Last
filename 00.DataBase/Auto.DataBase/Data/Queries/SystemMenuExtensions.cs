using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemMenuExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.SystemMenu GetByKey(this IQueryable<Auto.EFCore.Entities.SystemMenu> queryable, int menuId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemMenu> dbSet)
                return dbSet.Find(menuId);

            return queryable.FirstOrDefault(q => q.MenuId == menuId);
        }

        public static ValueTask<Auto.EFCore.Entities.SystemMenu> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.SystemMenu> queryable, int menuId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemMenu> dbSet)
                return dbSet.FindAsync(menuId);

            var task = queryable.FirstOrDefaultAsync(q => q.MenuId == menuId);
            return new ValueTask<Auto.EFCore.Entities.SystemMenu>(task);
        }

        #endregion

    }
}
