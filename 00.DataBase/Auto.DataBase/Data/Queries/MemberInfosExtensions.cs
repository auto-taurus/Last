using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberInfosExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.MemberInfos GetByKey(this IQueryable<AutoNews.Data.Entities.MemberInfos> queryable, int memberId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberInfos> dbSet)
                return dbSet.Find(memberId);

            return queryable.FirstOrDefault(q => q.MemberId == memberId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberInfos> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberInfos> queryable, int memberId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberInfos> dbSet)
                return dbSet.FindAsync(memberId);

            var task = queryable.FirstOrDefaultAsync(q => q.MemberId == memberId);
            return new ValueTask<AutoNews.Data.Entities.MemberInfos>(task);
        }

        #endregion

    }
}
