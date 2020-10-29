using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class SystemRoleExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.SystemRole GetByKey(this IQueryable<Master.Data.Entities.SystemRole> queryable, int roleId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemRole> dbSet)
                return dbSet.Find(roleId);

            return queryable.FirstOrDefault(q => q.RoleId == roleId);
        }

        public static ValueTask<Master.Data.Entities.SystemRole> GetByKeyAsync(this IQueryable<Master.Data.Entities.SystemRole> queryable, int roleId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemRole> dbSet)
                return dbSet.FindAsync(roleId);

            var task = queryable.FirstOrDefaultAsync(q => q.RoleId == roleId);
            return new ValueTask<Master.Data.Entities.SystemRole>(task);
        }

        #endregion

    }
}
