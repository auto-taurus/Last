using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.ApiHandles.Responses {
    public class Response<TModal> : IResponse<TModal> where TModal : class {
        public Boolean Code { get; set; } = true;
        public String Message { get; set; }
        public TModal Data { get; set; }
        public Object Other { get; set; }
    }
}
