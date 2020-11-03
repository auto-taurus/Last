using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class WebChannelExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.WebChannel GetByKey(this IQueryable<AutoNews.Data.Entities.WebChannel> queryable, int channelId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebChannel> dbSet)
                return dbSet.Find(channelId);

            return queryable.FirstOrDefault(q => q.ChannelId == channelId);
        }

        public static ValueTask<AutoNews.Data.Entities.WebChannel> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.WebChannel> queryable, int channelId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.WebChannel> dbSet)
                return dbSet.FindAsync(channelId);

            var task = queryable.FirstOrDefaultAsync(q => q.ChannelId == channelId);
            return new ValueTask<AutoNews.Data.Entities.WebChannel>(task);
        }

        #endregion

    }
}
