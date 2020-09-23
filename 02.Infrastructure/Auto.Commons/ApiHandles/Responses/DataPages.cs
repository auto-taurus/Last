using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Commons.ApiHandles.Responses {
    public class DataPages<TModal> where TModal : class {
        public IList<TModal> Entities { get; set; }
        public int? PageCount { get; set; }
    }
}
