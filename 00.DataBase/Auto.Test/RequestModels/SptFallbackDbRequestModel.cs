using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SptFallbackDbRequestModel
	{
		[StringLength(30)]
		public String XserverName { get; set; }

		public DateTime? XdttmIns { get; set; }

		public DateTime? XdttmLastInsUpd { get; set; }

		public Int16? XfallbackDbid { get; set; }

		[StringLength(30)]
		public String Name { get; set; }

		public Int16? Dbid { get; set; }

		public Int16? Status { get; set; }

		public Int16? Version { get; set; }
	}
}
