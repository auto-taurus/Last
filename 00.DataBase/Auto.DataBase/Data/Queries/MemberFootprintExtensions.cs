using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberFootprintExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.MemberFootprint GetByKey(this IQueryable<Master.Data.Entities.MemberFootprint> queryable, int footprintId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberFootprint> dbSet)
                return dbSet.Find(footprintId);

            return queryable.FirstOrDefault(q => q.FootprintId == footprintId);
        }

        public static ValueTask<Master.Data.Entities.MemberFootprint> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberFootprint> queryable, int footprintId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberFootprint> dbSet)
                return dbSet.FindAsync(footprintId);

            var task = queryable.FirstOrDefaultAsync(q => q.FootprintId == footprintId);
            return new ValueTask<Master.Data.Entities.MemberFootprint>(task);
        }

        public static IQueryable<Master.Data.Entities.MemberFootprint> ByMemberId(this IQueryable<Master.Data.Entities.MemberFootprint> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        #endregion

    }
}
