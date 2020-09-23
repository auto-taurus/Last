using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.ApiHandles.Responses {
    public interface IResponseBase {
        Boolean Code { get; set; }
        String Message { get; set; }
        Object Other { get; set; }
    }
}
