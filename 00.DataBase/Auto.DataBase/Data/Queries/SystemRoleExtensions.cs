using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class SystemRoleExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.SystemRole GetByKey(this IQueryable<AutoNews.Data.Entities.SystemRole> queryable, int roleId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemRole> dbSet)
                return dbSet.Find(roleId);

            return queryable.FirstOrDefault(q => q.RoleId == roleId);
        }

        public static ValueTask<AutoNews.Data.Entities.SystemRole> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.SystemRole> queryable, int roleId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemRole> dbSet)
                return dbSet.FindAsync(roleId);

            var task = queryable.FirstOrDefaultAsync(q => q.RoleId == roleId);
            return new ValueTask<AutoNews.Data.Entities.SystemRole>(task);
        }

        #endregion

    }
}
