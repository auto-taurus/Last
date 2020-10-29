using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class SystemUsersDictionaryExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.SystemUsersDictionary GetByKey(this IQueryable<Master.Data.Entities.SystemUsersDictionary> queryable, int id)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemUsersDictionary> dbSet)
                return dbSet.Find(id);

            return queryable.FirstOrDefault(q => q.Id == id);
        }

        public static ValueTask<Master.Data.Entities.SystemUsersDictionary> GetByKeyAsync(this IQueryable<Master.Data.Entities.SystemUsersDictionary> queryable, int id)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemUsersDictionary> dbSet)
                return dbSet.FindAsync(id);

            var task = queryable.FirstOrDefaultAsync(q => q.Id == id);
            return new ValueTask<Master.Data.Entities.SystemUsersDictionary>(task);
        }

        public static IQueryable<Master.Data.Entities.SystemUsersDictionary> ByUserId(this IQueryable<Master.Data.Entities.SystemUsersDictionary> queryable, int userId)
        {
            return queryable.Where(q => q.UserId == userId);
        }

        #endregion

    }
}
