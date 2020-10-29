using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class SystemDictionaryExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.SystemDictionary GetByKey(this IQueryable<Master.Data.Entities.SystemDictionary> queryable, int dictionaryId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemDictionary> dbSet)
                return dbSet.Find(dictionaryId);

            return queryable.FirstOrDefault(q => q.DictionaryId == dictionaryId);
        }

        public static ValueTask<Master.Data.Entities.SystemDictionary> GetByKeyAsync(this IQueryable<Master.Data.Entities.SystemDictionary> queryable, int dictionaryId)
        {
            if (queryable is DbSet<Master.Data.Entities.SystemDictionary> dbSet)
                return dbSet.FindAsync(dictionaryId);

            var task = queryable.FirstOrDefaultAsync(q => q.DictionaryId == dictionaryId);
            return new ValueTask<Master.Data.Entities.SystemDictionary>(task);
        }

        #endregion

    }
}
