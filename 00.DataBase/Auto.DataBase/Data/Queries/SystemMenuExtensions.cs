using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class SystemMenuExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.SystemMenu GetByKey(this IQueryable<Master.Data.Entities.SystemMenu> queryable, int menuId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemMenu> dbSet)
                return dbSet.Find(menuId);

            return queryable.FirstOrDefault(q => q.MenuId == menuId);
        }

        public static ValueTask<Master.Data.Entities.SystemMenu> GetByKeyAsync(this IQueryable<Master.Data.Entities.SystemMenu> queryable, int menuId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemMenu> dbSet)
                return dbSet.FindAsync(menuId);

            var task = queryable.FirstOrDefaultAsync(q => q.MenuId == menuId);
            return new ValueTask<Master.Data.Entities.SystemMenu>(task);
        }

        #endregion

    }
}
