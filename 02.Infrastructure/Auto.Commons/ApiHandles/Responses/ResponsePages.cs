using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.ApiHandles.Responses {
    public class ResponsePages<TModal> : IResponsePages<TModal> where TModal : class {
        public bool Code { get; set; } = false;
        public string Message { get; set; }
        public DataPages<TModal> Data { get; set; }
        public object Other { get; set; }
    }
}
