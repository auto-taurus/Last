using System;

namespace Gbxx.BackStage.Responses
{
	public interface IResponse
	{
		String Message { get; set; }
		Boolean DidError { get; set; }
		String ErrorMessage { get; set; }
	}
}
