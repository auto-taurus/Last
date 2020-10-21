using System.Collections.Generic;

namespace Northwind.WebAPI.Responses
{
	public interface IListResponse<TModel> : IResponse where TModel : class
	{
		IEnumerable<TModel> Model { get; set; }
	}
}
