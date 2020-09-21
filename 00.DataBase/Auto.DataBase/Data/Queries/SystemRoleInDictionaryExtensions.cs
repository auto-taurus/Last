using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemRoleInDictionaryExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.SystemRoleInDictionary GetByKey(this IQueryable<Auto.EFCore.Entities.SystemRoleInDictionary> queryable, int id)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemRoleInDictionary> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Auto.EFCore.Entities.SystemRoleInDictionary> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.SystemRoleInDictionary> queryable, int id)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemRoleInDictionary> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Auto.EFCore.Entities.SystemRoleInDictionary>(task);
        }

        public static IQueryable<Auto.EFCore.Entities.SystemRoleInDictionary> ByRoleId(this IQueryable<Auto.EFCore.Entities.SystemRoleInDictionary> queryable, int roleId)
        {
            return queryable.Where(q => q.RoleId == roleId);
        }

        #endregion

    }
}
