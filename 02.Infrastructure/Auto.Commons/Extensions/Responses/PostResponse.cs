using System;
using System.Collections.Generic;

namespace Auto.Commons.Extensions.Responses {
    public class PostResponse : Response, IPostResponse {
        public object Id { get; set; }
    }
}
