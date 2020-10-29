using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class SystemRoleDictionaryExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.SystemRoleDictionary GetByKey(this IQueryable<Master.Data.Entities.SystemRoleDictionary> queryable, int id)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemRoleDictionary> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Master.Data.Entities.SystemRoleDictionary> GetByKeyAsync(this IQueryable<Master.Data.Entities.SystemRoleDictionary> queryable, int id)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemRoleDictionary> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Master.Data.Entities.SystemRoleDictionary>(task);
        }

        public static IQueryable<Master.Data.Entities.SystemRoleDictionary> ByRoleId(this IQueryable<Master.Data.Entities.SystemRoleDictionary> queryable, int roleId)
        {
            return queryable.Where(q => q.RoleId == roleId);
        }

        #endregion

    }
}
