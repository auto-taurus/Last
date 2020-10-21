using System;

namespace Northwind.WebAPI.Responses
{
	public interface IResponse
	{
		String Message { get; set; }

		Boolean DidError { get; set; }

		String ErrorMessage { get; set; }
	}
}
