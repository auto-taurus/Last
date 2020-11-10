using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class SystemDictionaryExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.SystemDictionary GetByKey(this IQueryable<AutoNews.Data.Entities.SystemDictionary> queryable, int dictionaryId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemDictionary> dbSet)
                return dbSet.Find(dictionaryId);

            return queryable.FirstOrDefault(q => q.DictionaryId == dictionaryId);
        }

        public static ValueTask<AutoNews.Data.Entities.SystemDictionary> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.SystemDictionary> queryable, int dictionaryId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.SystemDictionary> dbSet)
                return dbSet.FindAsync(dictionaryId);

            var task = queryable.FirstOrDefaultAsync(q => q.DictionaryId == dictionaryId);
            return new ValueTask<AutoNews.Data.Entities.SystemDictionary>(task);
        }

        #endregion

    }
}
