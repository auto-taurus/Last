using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class SystemRoleInMenuExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.SystemRoleInMenu GetByKey(this IQueryable<AutoNews.Data.Entities.SystemRoleInMenu> queryable, int id)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemRoleInMenu> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<AutoNews.Data.Entities.SystemRoleInMenu> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.SystemRoleInMenu> queryable, int id)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemRoleInMenu> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<AutoNews.Data.Entities.SystemRoleInMenu>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.SystemRoleInMenu> ByMenuId(this IQueryable<AutoNews.Data.Entities.SystemRoleInMenu> queryable, int? menuId)
        {
            return queryable.Where(q => (q.MenuId == menuId || (menuId == null && q.MenuId == null)));
        }

        public static IQueryable<AutoNews.Data.Entities.SystemRoleInMenu> ByRoleId(this IQueryable<AutoNews.Data.Entities.SystemRoleInMenu> queryable, int? roleId)
        {
            return queryable.Where(q => (q.RoleId == roleId || (roleId == null && q.RoleId == null)));
        }

        #endregion

    }
}
