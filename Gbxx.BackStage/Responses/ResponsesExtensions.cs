using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gbxx.BackStage.Responses
{
	public static class ResponsesExtensions
	{
		public static void SetError(this IResponse response, Exception ex, ILogger logger)
		{
			response.DidError = true;
			response.ErrorMessage = ex.Message;
			
			// todo: Add logic to save exception in file
			logger?.LogError(ex.ToString());
		}

		public static IActionResult  ToHttpResponse<TModel>(this ISingleResponse<TModel> response) where TModel : class
		{
			var status = HttpStatusCode.OK;
			
			if (response.Model == null)
			{
				status = HttpStatusCode.NotFound;
			}
			
			if (response.DidError)
			{
				status = HttpStatusCode.InternalServerError;
			}
			
			return new ObjectResult(response)
			{
				StatusCode = (Int32)status
			};
		}

		public static IActionResult  ToHttpResponse<TModel>(this IListResponse<TModel> response) where TModel : class
		{
			var status = HttpStatusCode.OK;
			
			if (response.Model == null)
			{
				status = HttpStatusCode.NoContent;
			}
			
			if (response.DidError)
			{
				status = HttpStatusCode.InternalServerError;
			}
			
			return new ObjectResult(response)
			{
				StatusCode = (Int32)status
			};
		}
	}
}
