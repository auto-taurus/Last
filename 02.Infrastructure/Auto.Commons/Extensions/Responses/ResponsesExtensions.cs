using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Auto.Commons.Extensions.Responses {
    public static class ResponsesExtensions {
        public static void SetError(this IResponse response, ILogger logger, string action, Exception ex) {
            response.DidError = true;
            response.ErrorMessage = ex.Message;

            // todo: Add additional logic to save exception
            logger?.LogCritical("There was an error on '{0}': {1}", action, ex);
        }
        public static IActionResult ToHttpResult(this IResponse response) {
            var status = HttpStatusCode.OK;

            if (response.DidError)
                status = HttpStatusCode.InternalServerError;

            return new ObjectResult(response) {
                StatusCode = (int)status
            };
        }
        public static IActionResult ToHttpResult<TModel>(this IListResponse<TModel> response) where TModel : class {
            var status = HttpStatusCode.OK;

            if (response.Model == null)
                status = HttpStatusCode.NoContent;

            if (response.DidError)
                status = HttpStatusCode.InternalServerError;

            return new ObjectResult(response) {
                StatusCode = (int)status
            };
        }

        public static IActionResult ToHttpResult<TModel>(this ISingleResponse<TModel> response) where TModel : class {
            var status = HttpStatusCode.OK;

            if (response.Model == null)
                status = HttpStatusCode.NotFound;

            if (response.DidError)
                status = HttpStatusCode.InternalServerError;

            return new ObjectResult(response) {
                StatusCode = (int)status
            };
        }

        public static IActionResult ToHttpResult(this IPostResponse response) {
            var status = HttpStatusCode.Created;

            if (response.DidError)
                status = HttpStatusCode.InternalServerError;

            return new ObjectResult(response) {
                StatusCode = (int)status
            };
        }
    }
}
