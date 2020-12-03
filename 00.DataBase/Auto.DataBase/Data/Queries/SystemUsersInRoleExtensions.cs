using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class SystemUsersInRoleExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.SystemUsersInRole GetByKey(this IQueryable<AutoNews.Data.Entities.SystemUsersInRole> queryable, int id)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemUsersInRole> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<AutoNews.Data.Entities.SystemUsersInRole> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.SystemUsersInRole> queryable, int id)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemUsersInRole> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<AutoNews.Data.Entities.SystemUsersInRole>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.SystemUsersInRole> ByRoleId(this IQueryable<AutoNews.Data.Entities.SystemUsersInRole> queryable, int? roleId)
        {
            return queryable.Where(q => (q.RoleId == roleId || (roleId == null && q.RoleId == null)));
        }

        public static IQueryable<AutoNews.Data.Entities.SystemUsersInRole> ByUsersId(this IQueryable<AutoNews.Data.Entities.SystemUsersInRole> queryable, int? usersId)
        {
            return queryable.Where(q => (q.UsersId == usersId || (usersId == null && q.UsersId == null)));
        }

        #endregion

    }
}
