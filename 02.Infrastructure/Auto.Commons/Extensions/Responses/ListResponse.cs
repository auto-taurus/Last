using System;
using System.Collections.Generic;

namespace Auto.Commons.Extensions.Responses {
    public class ListResponse<TModel> : Response, IListResponse<TModel> where TModel : class {
        public IEnumerable<TModel> Model { get; set; }

    }
}
