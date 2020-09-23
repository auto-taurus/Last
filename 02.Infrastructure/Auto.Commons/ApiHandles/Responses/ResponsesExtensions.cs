using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Auto.Commons.ApiHandles.Responses {
    public static class ResponsesExtensions {
        public static void SetError(this IResponseBase response, Exception ex, ILogger logger) {
            response.Code = false;
            response.Message = "系统内部错误！";
            // todo: Add logic to save exception in file
            logger?.LogError(ex.ToString());
        }
        public static IActionResult ToHttpResponse<TModal>(this IResponse<TModal> response) where TModal : class {
            var status = HttpStatusCode.OK;
            //if (response.Data == null) {
            //    status = HttpStatusCode.NotFound;
            //}
            return new ObjectResult(response) {
                StatusCode = (Int32)status
            };
        }
        public static IActionResult ToHttpResponse<TModal>(this IResponseList<TModal> response) where TModal : class {
            var status = HttpStatusCode.OK;

            if (response.Data == null) {
                status = HttpStatusCode.NoContent;
            }
            return new ObjectResult(response) {
                StatusCode = (Int32)status
            };
        }
        public static IActionResult ToHttpResponse<TModal>(this IResponsePages<TModal> response) where TModal : class {
            var status = HttpStatusCode.OK;

            if (response.Data == null) {
                status = HttpStatusCode.NoContent;
            }
            else if (response.Data.Entities == null)
                status = HttpStatusCode.NoContent;
            return new ObjectResult(response) {
                StatusCode = (Int32)status
            };
        }
    }
}
