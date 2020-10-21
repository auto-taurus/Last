using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SystemDictionaryRequestModel
	{
		[Key]
		public Int32? DictionaryId { get; set; }

		[StringLength(20)]
		public String TypeKey { get; set; }

		[StringLength(20)]
		public String DistKey { get; set; }

		[StringLength(40)]
		public String DistName { get; set; }

		[StringLength(510)]
		public String DistValue { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }
	}
}
