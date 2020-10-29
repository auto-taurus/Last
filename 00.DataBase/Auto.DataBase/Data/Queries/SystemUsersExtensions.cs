using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class SystemUsersExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.SystemUsers GetByKey(this IQueryable<Master.Data.Entities.SystemUsers> queryable, int usersId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemUsers> dbSet)
                return dbSet.Find(usersId);

            return queryable.FirstOrDefault(q => q.UsersId == usersId);
        }

        public static ValueTask<Master.Data.Entities.SystemUsers> GetByKeyAsync(this IQueryable<Master.Data.Entities.SystemUsers> queryable, int usersId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemUsers> dbSet)
                return dbSet.FindAsync(usersId);

            var task = queryable.FirstOrDefaultAsync(q => q.UsersId == usersId);
            return new ValueTask<Master.Data.Entities.SystemUsers>(task);
        }

        #endregion

    }
}
