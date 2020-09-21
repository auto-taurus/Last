using System;

namespace Auto.Commons.Extensions.Responses {
    public interface IResponse {
        string Message { get; set; }

        bool DidError { get; set; }

        string ErrorMessage { get; set; }
    }
}
