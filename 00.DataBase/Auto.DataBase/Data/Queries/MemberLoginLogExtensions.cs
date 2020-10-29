using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberLoginLogExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.MemberLoginLog GetByKey(this IQueryable<Master.Data.Entities.MemberLoginLog> queryable, decimal loginLogId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberLoginLog> dbSet)
                return dbSet.Find(loginLogId);

            return queryable.FirstOrDefault(q => q.LoginLogId == loginLogId);
        }

        public static ValueTask<Master.Data.Entities.MemberLoginLog> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberLoginLog> queryable, decimal loginLogId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberLoginLog> dbSet)
                return dbSet.FindAsync(loginLogId);

            var task = queryable.FirstOrDefaultAsync(q => q.LoginLogId == loginLogId);
            return new ValueTask<Master.Data.Entities.MemberLoginLog>(task);
        }

        #endregion

    }
}
