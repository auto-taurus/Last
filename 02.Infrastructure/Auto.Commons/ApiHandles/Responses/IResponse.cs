using System;

namespace Auto.Commons.ApiHandles.Responses {
    public interface IResponse<TObject> {
        Boolean Code { get; set; } 
        String Message { get; set; }
        TObject Data { get; set; }
        Object Other { get; set; }
    }
}
