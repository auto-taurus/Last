using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberInfosExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.MemberInfos GetByKey(this IQueryable<Master.Data.Entities.MemberInfos> queryable, int memberId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberInfos> dbSet)
                return dbSet.Find(memberId);

            return queryable.FirstOrDefault(q => q.MemberId == memberId);
        }

        public static ValueTask<Master.Data.Entities.MemberInfos> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberInfos> queryable, int memberId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberInfos> dbSet)
                return dbSet.FindAsync(memberId);

            var task = queryable.FirstOrDefaultAsync(q => q.MemberId == memberId);
            return new ValueTask<Master.Data.Entities.MemberInfos>(task);
        }

        #endregion

    }
}
