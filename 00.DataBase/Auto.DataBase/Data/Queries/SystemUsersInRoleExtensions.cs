using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class SystemUsersInRoleExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.SystemUsersInRole GetByKey(this IQueryable<Master.Data.Entities.SystemUsersInRole> queryable, int id)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemUsersInRole> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Master.Data.Entities.SystemUsersInRole> GetByKeyAsync(this IQueryable<Master.Data.Entities.SystemUsersInRole> queryable, int id)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemUsersInRole> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Master.Data.Entities.SystemUsersInRole>(task);
        }

        public static IQueryable<Master.Data.Entities.SystemUsersInRole> ByRoleId(this IQueryable<Master.Data.Entities.SystemUsersInRole> queryable, int? roleId)
        {
            return queryable.Where(q => (q.RoleId == roleId || (roleId == null && q.RoleId == null)));
        }

        public static IQueryable<Master.Data.Entities.SystemUsersInRole> ByUsersId(this IQueryable<Master.Data.Entities.SystemUsersInRole> queryable, int? usersId)
        {
            return queryable.Where(q => (q.UsersId == usersId || (usersId == null && q.UsersId == null)));
        }

        #endregion

    }
}
