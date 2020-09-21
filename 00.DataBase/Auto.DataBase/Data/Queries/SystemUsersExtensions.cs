using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemUsersExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.SystemUsers GetByKey(this IQueryable<Auto.EFCore.Entities.SystemUsers> queryable, int usersId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemUsers> dbSet)
                return dbSet.Find(usersId);

            return queryable.FirstOrDefault(q => q.UsersId == usersId);
        }

        public static ValueTask<Auto.EFCore.Entities.SystemUsers> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.SystemUsers> queryable, int usersId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemUsers> dbSet)
                return dbSet.FindAsync(usersId);

            var task = queryable.FirstOrDefaultAsync(q => q.UsersId == usersId);
            return new ValueTask<Auto.EFCore.Entities.SystemUsers>(task);
        }

        #endregion

    }
}
