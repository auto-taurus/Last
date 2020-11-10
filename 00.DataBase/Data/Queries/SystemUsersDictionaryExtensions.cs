using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class SystemUsersDictionaryExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.SystemUsersDictionary GetByKey(this IQueryable<AutoNews.Data.Entities.SystemUsersDictionary> queryable, int id)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemUsersDictionary> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<AutoNews.Data.Entities.SystemUsersDictionary> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.SystemUsersDictionary> queryable, int id)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemUsersDictionary> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<AutoNews.Data.Entities.SystemUsersDictionary>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.SystemUsersDictionary> ByUserId(this IQueryable<AutoNews.Data.Entities.SystemUsersDictionary> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
