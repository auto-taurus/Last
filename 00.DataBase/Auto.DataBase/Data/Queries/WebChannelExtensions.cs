using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class WebChannelExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.WebChannel GetByKey(this IQueryable<Master.Data.Entities.WebChannel> queryable, int channelId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebChannel> dbSet)
                return dbSet.Find(channelId);

            return queryable.FirstOrDefault(q => q.ChannelId == channelId);
        }

        public static ValueTask<Master.Data.Entities.WebChannel> GetByKeyAsync(this IQueryable<Master.Data.Entities.WebChannel> queryable, int channelId)
        {
            if (queryable is DbSet<Master.Data.Entities.WebChannel> dbSet)
                return dbSet.FindAsync(channelId);

            var task = queryable.FirstOrDefaultAsync(q => q.ChannelId == channelId);
            return new ValueTask<Master.Data.Entities.WebChannel>(task);
        }

        #endregion

    }
}
