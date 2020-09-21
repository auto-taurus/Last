using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class WebChannelExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.WebChannel GetByKey(this IQueryable<Auto.EFCore.Entities.WebChannel> queryable, int channelId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebChannel> dbSet)
                return dbSet.Find(channelId);

            return queryable.FirstOrDefault(q => q.ChannelId == channelId);
        }

        public static ValueTask<Auto.EFCore.Entities.WebChannel> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.WebChannel> queryable, int channelId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.WebChannel> dbSet)
                return dbSet.FindAsync(channelId);

            var task = queryable.FirstOrDefaultAsync(q => q.ChannelId == channelId);
            return new ValueTask<Auto.EFCore.Entities.WebChannel>(task);
        }

        #endregion

    }
}
