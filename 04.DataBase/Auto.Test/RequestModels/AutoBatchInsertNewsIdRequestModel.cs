using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class AutoBatchInsertNewsIdRequestModel
	{
		[Key]
		public Int32? Id { get; set; }

		public Int32? NewsId { get; set; }

		public String Message { get; set; }
	}
}
