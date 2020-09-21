using System;

namespace Auto.Commons.Extensions.Responses {
    public interface IPostResponse : IResponse {
        object Id { get; set; }
    }
}
