using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemUsersInDictionaryExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.SystemUsersInDictionary GetByKey(this IQueryable<Auto.EFCore.Entities.SystemUsersInDictionary> queryable, int id)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemUsersInDictionary> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Auto.EFCore.Entities.SystemUsersInDictionary> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.SystemUsersInDictionary> queryable, int id)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemUsersInDictionary> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Auto.EFCore.Entities.SystemUsersInDictionary>(task);
        }

        public static IQueryable<Auto.EFCore.Entities.SystemUsersInDictionary> ByUserId(this IQueryable<Auto.EFCore.Entities.SystemUsersInDictionary> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
