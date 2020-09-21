using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemRoleExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.SystemRole GetByKey(this IQueryable<Auto.EFCore.Entities.SystemRole> queryable, int roleId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemRole> dbSet)
                return dbSet.Find(roleId);

            return queryable.FirstOrDefault(q => q.RoleId == roleId);
        }

        public static ValueTask<Auto.EFCore.Entities.SystemRole> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.SystemRole> queryable, int roleId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemRole> dbSet)
                return dbSet.FindAsync(roleId);

            var task = queryable.FirstOrDefaultAsync(q => q.RoleId == roleId);
            return new ValueTask<Auto.EFCore.Entities.SystemRole>(task);
        }

        #endregion

    }
}
