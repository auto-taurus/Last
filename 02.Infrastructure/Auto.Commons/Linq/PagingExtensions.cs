using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Auto.Commons.Linq {
    public static class PagingExtensions {
        public static IQueryable<TModel> ToPager<TModel>(this IQueryable<TModel> query, int pageIndex = 0, int pageSize = 0) where TModel : class {
            return pageSize > 0 && pageIndex > 0 ? query.Skip((pageIndex - 1) * pageSize).Take(pageSize) : query;
        }
    }
}
