using System.Collections.Generic;

namespace Auto.Commons.Extensions.Responses
{
	public interface IListResponse<TModel> : IResponse where TModel : class
	{
		IEnumerable<TModel> Model { get; set; }
	}
}
