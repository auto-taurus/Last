using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemUsersRefreshTokenExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.SystemUsersRefreshToken GetByKey(this IQueryable<Auto.EFCore.Entities.SystemUsersRefreshToken> queryable, int refreshTokenId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemUsersRefreshToken> dbSet)
                return dbSet.Find(refreshTokenId);

            return queryable.FirstOrDefault(q => q.RefreshTokenId == refreshTokenId);
        }

        public static ValueTask<Auto.EFCore.Entities.SystemUsersRefreshToken> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.SystemUsersRefreshToken> queryable, int refreshTokenId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemUsersRefreshToken> dbSet)
                return dbSet.FindAsync(refreshTokenId);

            var task = queryable.FirstOrDefaultAsync(q => q.RefreshTokenId == refreshTokenId);
            return new ValueTask<Auto.EFCore.Entities.SystemUsersRefreshToken>(task);
        }

        #endregion

    }
}
