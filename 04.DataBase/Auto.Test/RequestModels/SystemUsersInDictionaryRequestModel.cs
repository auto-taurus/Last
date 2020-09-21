using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class SystemUsersInDictionaryRequestModel
	{
		[Key]
		public Int32? Id { get; set; }

		[Required]
		public Int32? UserId { get; set; }

		[StringLength(20)]
		public String DictionaryKey { get; set; }

		[StringLength(200)]
		public String DictionaryValue { get; set; }
	}
}
