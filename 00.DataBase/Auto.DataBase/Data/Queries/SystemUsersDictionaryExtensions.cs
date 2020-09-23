using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemUsersDictionaryExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.SystemUsersDictionary GetByKey(this IQueryable<Auto.EFCore.Entities.SystemUsersDictionary> queryable, int id)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemUsersDictionary> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Auto.EFCore.Entities.SystemUsersDictionary> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.SystemUsersDictionary> queryable, int id)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemUsersDictionary> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Auto.EFCore.Entities.SystemUsersDictionary>(task);
        }

        public static IQueryable<Auto.EFCore.Entities.SystemUsersDictionary> ByUserId(this IQueryable<Auto.EFCore.Entities.SystemUsersDictionary> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
