using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class SystemUsersRefreshTokenExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.SystemUsersRefreshToken GetByKey(this IQueryable<Master.Data.Entities.SystemUsersRefreshToken> queryable, int refreshTokenId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemUsersRefreshToken> dbSet)
                return dbSet.Find(refreshTokenId);

            return queryable.FirstOrDefault(q => q.RefreshTokenId == refreshTokenId);
        }

        public static ValueTask<Master.Data.Entities.SystemUsersRefreshToken> GetByKeyAsync(this IQueryable<Master.Data.Entities.SystemUsersRefreshToken> queryable, int refreshTokenId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemUsersRefreshToken> dbSet)
                return dbSet.FindAsync(refreshTokenId);

            var task = queryable.FirstOrDefaultAsync(q => q.RefreshTokenId == refreshTokenId);
            return new ValueTask<Master.Data.Entities.SystemUsersRefreshToken>(task);
        }

        #endregion

    }
}
