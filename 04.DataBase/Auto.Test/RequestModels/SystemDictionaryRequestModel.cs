using System;
using System.ComponentModel.DataAnnotations;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;
using OnlineStoreWithFluentValidationWebAPI.EntityLayer;

namespace OnlineStoreWithFluentValidation.WebAPI.RequestModels
{
	public class SystemDictionaryRequestModel
	{
		[Key]
		public Int32? DictionaryId { get; set; }

		[StringLength(50)]
		public String Keys { get; set; }

		[StringLength(510)]
		public String Name { get; set; }

		[StringLength(2000)]
		public String Value { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }
	}
}
