using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class SystemUsersInMenuExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.SystemUsersInMenu GetByKey(this IQueryable<Master.Data.Entities.SystemUsersInMenu> queryable, int id)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemUsersInMenu> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Master.Data.Entities.SystemUsersInMenu> GetByKeyAsync(this IQueryable<Master.Data.Entities.SystemUsersInMenu> queryable, int id)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemUsersInMenu> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Master.Data.Entities.SystemUsersInMenu>(task);
        }

        public static IQueryable<Master.Data.Entities.SystemUsersInMenu> ByMenuId(this IQueryable<Master.Data.Entities.SystemUsersInMenu> queryable, int? menuId)
        {
            return queryable.Where(q => (q.MenuId == menuId || (menuId == null && q.MenuId == null)));
        }

        public static IQueryable<Master.Data.Entities.SystemUsersInMenu> ByUserId(this IQueryable<Master.Data.Entities.SystemUsersInMenu> queryable, int? userId)
        {
            return queryable.Where(q => (q.UserId == userId || (userId == null && q.UserId == null)));
        }

        #endregion

    }
}
