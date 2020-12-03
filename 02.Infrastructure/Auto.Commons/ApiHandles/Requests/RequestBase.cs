using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.ApiHandles.Requests {
    public class RequestBase {
        public RequestBase() {
            PageIndex = 1;
            PageSize = 10;
        }
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }
    }
}
