using System.Collections.Generic;

namespace Gbxx.BackStage.Responses
{
	public interface IListResponse<TModel> : IResponse where TModel : class
	{
		IEnumerable<TModel> Model { get; set; }
	}
}
