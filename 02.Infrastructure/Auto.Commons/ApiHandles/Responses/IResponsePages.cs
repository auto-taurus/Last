using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.ApiHandles.Responses {
    public interface IResponsePages<TModal> : IResponseBase where TModal : class {
        DataPages<TModal> Data { get; set; }
    }
}
