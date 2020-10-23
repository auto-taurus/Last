using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SptFallbackUsgRequestModel
	{
		[StringLength(30)]
		public String XserverName { get; set; }

		public DateTime? XdttmIns { get; set; }

		public DateTime? XdttmLastInsUpd { get; set; }

		public Int32? XfallbackVstart { get; set; }

		public Int16? Dbid { get; set; }

		public Int32? Segmap { get; set; }

		public Int32? Lstart { get; set; }

		public Int32? Sizepg { get; set; }

		public Int32? Vstart { get; set; }
	}
}
