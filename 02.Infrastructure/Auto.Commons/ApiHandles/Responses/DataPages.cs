using System.Collections.Generic;

namespace Auto.Commons.ApiHandles.Responses {
    public class DataPages<TObject> {
        public IList<TObject> Entities { get; set; }
        public int? PageCount { get; set; }
    }
}
