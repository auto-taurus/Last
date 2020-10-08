using System;

namespace Auto.Commons.ApiHandles.Responses {
    public class Response<TObject> : IResponse<TObject> {
        public Boolean Code { get; set; }
        public String Message { get; set; }
        public TObject Data { get; set; }
        public Object Other { get; set; }
    }
}
