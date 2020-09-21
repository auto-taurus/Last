using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemDictionaryExtensions
    {
        #region Generated Extensions
        public static Auto.EFCore.Entities.SystemDictionary GetByKey(this IQueryable<Auto.EFCore.Entities.SystemDictionary> queryable, int dictionaryId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemDictionary> dbSet)
                return dbSet.Find(dictionaryId);

            return queryable.FirstOrDefault(q => q.DictionaryId == dictionaryId);
        }

        public static ValueTask<Auto.EFCore.Entities.SystemDictionary> GetByKeyAsync(this IQueryable<Auto.EFCore.Entities.SystemDictionary> queryable, int dictionaryId)
        {
            if (queryable is DbSet<Auto.EFCore.Entities.SystemDictionary> dbSet)
                return dbSet.FindAsync(dictionaryId);

            var task = queryable.FirstOrDefaultAsync(q => q.DictionaryId == dictionaryId);
            return new ValueTask<Auto.EFCore.Entities.SystemDictionary>(task);
        }

        #endregion

    }
}
