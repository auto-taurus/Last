using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.ApiHandles.Responses {
    public interface IResponseList<TModal> : IResponseBase where TModal : class {
        IList<TModal> Data { get; set; }
    }

}
