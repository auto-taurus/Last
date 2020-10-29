using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberMessageExtensions
    {
        #region Generated Extensions
        public static IQueryable<Master.Data.Entities.MemberMessage> ByMemberId(this IQueryable<Master.Data.Entities.MemberMessage> queryable, int? memberId)
        {
            return queryable.Where(q => (q.MemberId == memberId || (memberId == null && q.MemberId == null)));
        }

        public static Master.Data.Entities.MemberMessage GetByKey(this IQueryable<Master.Data.Entities.MemberMessage> queryable, int messageId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberMessage> dbSet)
                return dbSet.Find(messageId);

            return queryable.FirstOrDefault(q => q.MessageId == messageId);
        }

        public static ValueTask<Master.Data.Entities.MemberMessage> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberMessage> queryable, int messageId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberMessage> dbSet)
                return dbSet.FindAsync(messageId);

            var task = queryable.FirstOrDefaultAsync(q => q.MessageId == messageId);
            return new ValueTask<Master.Data.Entities.MemberMessage>(task);
        }

        #endregion

    }
}
