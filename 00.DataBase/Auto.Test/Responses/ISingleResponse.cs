namespace Northwind.WebAPI.Responses
{
	public interface ISingleResponse<TModel> : IResponse where TModel : class
	{
		TModel Model { get; set; }
	}
}
