﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Auto.EFCore {
    public static class PagingExtensions {
        public static IQueryable<TEntity> Paging<TEntity>(this AutoNewsContext dbContext, int pageIndex = 0, int pageSize = 0) where TEntity : class {
            var query = dbContext.Set<TEntity>().AsQueryable();
            return pageSize > 0 && pageIndex > 0 ? query.Skip((pageIndex - 1) * pageSize).Take(pageSize) : query;
        }

        public static IQueryable<TModel> Paging<TModel>(this IQueryable<TModel> query, int pageIndex = 0, int pageSize = 0) where TModel : class {
            return pageSize > 0 && pageIndex > 0 ? query.Skip((pageIndex - 1) * pageSize).Take(pageSize) : query;
        }
    }
}
