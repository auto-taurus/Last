using System;

namespace Auto.Commons.Extensions.Responses {
    public interface IPagedResponse<TModel> : IListResponse<TModel> where TModel : class {
        int PageSize { get; set; }
        int PageNumber { get; set; }
        int ItemsCount { get; set; }
        double PageCount { get; }
    }
}
