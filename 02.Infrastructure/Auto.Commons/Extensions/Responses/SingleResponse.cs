using System;

namespace Auto.Commons.Extensions.Responses
{
	public class SingleResponse<TModel> : Response, ISingleResponse<TModel> where TModel : class
	{
		public TModel Model { get; set; }

	}
}
