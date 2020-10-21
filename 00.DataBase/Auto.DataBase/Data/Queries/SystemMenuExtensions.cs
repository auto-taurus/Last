using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class SystemMenuExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.SystemMenu GetByKey(this IQueryable<AutoNews.Data.Entities.SystemMenu> queryable, int menuId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemMenu> dbSet)
                return dbSet.Find(menuId);

            return queryable.FirstOrDefault(q => q.MenuId == menuId);
        }

        public static ValueTask<AutoNews.Data.Entities.SystemMenu> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.SystemMenu> queryable, int menuId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemMenu> dbSet)
                return dbSet.FindAsync(menuId);

            var task = queryable.FirstOrDefaultAsync(q => q.MenuId == menuId);
            return new ValueTask<AutoNews.Data.Entities.SystemMenu>(task);
        }

        #endregion

    }
}
