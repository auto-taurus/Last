using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.ApiHandles.Responses {
    public interface IResponse<TModal> : IResponseBase {
        TModal Data { get; set; }
    }
}
