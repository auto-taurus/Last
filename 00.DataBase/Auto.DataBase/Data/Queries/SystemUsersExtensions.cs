using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class SystemUsersExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.SystemUsers GetByKey(this IQueryable<AutoNews.Data.Entities.SystemUsers> queryable, int usersId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemUsers> dbSet)
                return dbSet.Find(usersId);

            return queryable.FirstOrDefault(q => q.UsersId == usersId);
        }

        public static ValueTask<AutoNews.Data.Entities.SystemUsers> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.SystemUsers> queryable, int usersId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemUsers> dbSet)
                return dbSet.FindAsync(usersId);

            var task = queryable.FirstOrDefaultAsync(q => q.UsersId == usersId);
            return new ValueTask<AutoNews.Data.Entities.SystemUsers>(task);
        }

        #endregion

    }
}
