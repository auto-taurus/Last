using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class SystemUsersRefreshTokenExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.SystemUsersRefreshToken GetByKey(this IQueryable<AutoNews.Data.Entities.SystemUsersRefreshToken> queryable, int refreshTokenId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemUsersRefreshToken> dbSet)
                return dbSet.Find(refreshTokenId);

            return queryable.FirstOrDefault(q => q.RefreshTokenId == refreshTokenId);
        }

        public static ValueTask<AutoNews.Data.Entities.SystemUsersRefreshToken> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.SystemUsersRefreshToken> queryable, int refreshTokenId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemUsersRefreshToken> dbSet)
                return dbSet.FindAsync(refreshTokenId);

            var task = queryable.FirstOrDefaultAsync(q => q.RefreshTokenId == refreshTokenId);
            return new ValueTask<AutoNews.Data.Entities.SystemUsersRefreshToken>(task);
        }

        #endregion

    }
}
