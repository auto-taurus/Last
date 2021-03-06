using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;

namespace Auto.Commons.ApiHandles.Responses {
    public static class ResponseExtensions {
        public static void SetError<TObject>(this IResponse<TObject> response, Exception ex, ILogger logger) {
            response.Code = false;
            response.Message = "系统服务异常！";
            response.Other = ex;
            // todo: Add logic to save exception in file
            logger?.LogError(ex.ToString());

        }
        /// <summary>
        /// 基本数据
        /// </summary>
        /// <typeparam name="TModal"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        public static IActionResult ToHttpResponse<TObject>(this IResponse<TObject> response) where TObject : class {
            var status = HttpStatusCode.OK;
            if (response.Message == "系统服务异常！") {
                status = HttpStatusCode.InternalServerError;
            }
            return new ObjectResult(response) {
                StatusCode = (Int32)status
            };
        }
    }
}
