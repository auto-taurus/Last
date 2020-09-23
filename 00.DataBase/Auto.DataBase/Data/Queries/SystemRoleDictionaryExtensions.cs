using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemRoleDictionaryExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.SystemRoleDictionary GetByKey(this IQueryable<Auto.EFCore.Entities.SystemRoleDictionary> queryable, int id)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemRoleDictionary> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Auto.EFCore.Entities.SystemRoleDictionary> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.SystemRoleDictionary> queryable, int id)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemRoleDictionary> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Auto.EFCore.Entities.SystemRoleDictionary>(task);
        }

        public static IQueryable<Auto.EFCore.Entities.SystemRoleDictionary> ByRoleId(this IQueryable<Auto.EFCore.Entities.SystemRoleDictionary> queryable, int roleId)
        {
            return queryable.Where(q => q.RoleId == roleId);
        }

        #endregion

    }
}
