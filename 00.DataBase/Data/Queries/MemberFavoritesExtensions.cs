using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberFavoritesExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.MemberFavorites GetByKey(this IQueryable<AutoNews.Data.Entities.MemberFavorites> queryable, int favoritesId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberFavorites> dbSet)
                return dbSet.Find(favoritesId);

            return queryable.FirstOrDefault(q => q.FavoritesId == favoritesId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberFavorites> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberFavorites> queryable, int favoritesId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberFavorites> dbSet)
                return dbSet.FindAsync(favoritesId);

            var task = queryable.FirstOrDefaultAsync(q => q.FavoritesId == favoritesId);
            return new ValueTask<AutoNews.Data.Entities.MemberFavorites>(task);
        }

        public static IQueryable<AutoNews.Data.Entities.MemberFavorites> ByMemberId(this IQueryable<AutoNews.Data.Entities.MemberFavorites> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        #endregion

    }
}
