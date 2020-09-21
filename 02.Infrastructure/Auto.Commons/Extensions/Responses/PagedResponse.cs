using Auto.Commons.Extensions.Responses;
using System;
using System.Collections.Generic;

namespace Auto.Commons.Extensions.Responses {
    public class PagedResponse<TModel> : ListResponse<TModel>, IPagedResponse<TModel> where TModel : class {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public int ItemsCount { get; set; }

        public double PageCount
            => ItemsCount < PageSize ? 1 : (int)(((double)ItemsCount / PageSize) + 1);

    }
}
