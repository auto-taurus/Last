using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SptFallbackDevRequestModel
	{
		[StringLength(30)]
		public String XserverName { get; set; }

		public DateTime? XdttmIns { get; set; }

		public DateTime? XdttmLastInsUpd { get; set; }

		public Int32? XfallbackLow { get; set; }

		[StringLength(2)]
		public String XfallbackDrive { get; set; }

		public Int32? Low { get; set; }

		public Int32? High { get; set; }

		public Int16? Status { get; set; }

		[StringLength(30)]
		public String Name { get; set; }

		[StringLength(127)]
		public String Phyname { get; set; }
	}
}
