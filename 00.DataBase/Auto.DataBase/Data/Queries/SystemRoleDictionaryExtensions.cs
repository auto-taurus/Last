using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class SystemRoleDictionaryExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.SystemRoleDictionary GetByKey(this IQueryable<AutoNews.Data.Entities.SystemRoleDictionary> queryable, int id)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemRoleDictionary> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<AutoNews.Data.Entities.SystemRoleDictionary> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.SystemRoleDictionary> queryable, int id)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemRoleDictionary> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<AutoNews.Data.Entities.SystemRoleDictionary>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.SystemRoleDictionary> ByRoleId(this IQueryable<AutoNews.Data.Entities.SystemRoleDictionary> queryable, int roleId)
        {
            return queryable.Where(q => q.RoleId == roleId);
        }

        #endregion

    }
}
