using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberFavoritesExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.MemberFavorites GetByKey(this IQueryable<Master.Data.Entities.MemberFavorites> queryable, int favoritesId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberFavorites> dbSet)
                return dbSet.Find(favoritesId);

            return queryable.FirstOrDefault(q => q.FavoritesId == favoritesId);
        }

        public static ValueTask<Master.Data.Entities.MemberFavorites> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberFavorites> queryable, int favoritesId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberFavorites> dbSet)
                return dbSet.FindAsync(favoritesId);

            var task = queryable.FirstOrDefaultAsync(q => q.FavoritesId == favoritesId);
            return new ValueTask<Master.Data.Entities.MemberFavorites>(task);
        }

        public static IQueryable<Master.Data.Entities.MemberFavorites> ByMemberId(this IQueryable<Master.Data.Entities.MemberFavorites> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        #endregion

    }
}
