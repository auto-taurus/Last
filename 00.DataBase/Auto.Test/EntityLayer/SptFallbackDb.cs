using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SptFallbackDb : IEntity
	{
		public SptFallbackDb()
		{
		}

		public String XserverName { get; set; }

		public DateTime? XdttmIns { get; set; }

		public DateTime? XdttmLastInsUpd { get; set; }

		public Int16? XfallbackDbid { get; set; }

		public String Name { get; set; }

		public Int16? Dbid { get; set; }

		public Int16? Status { get; set; }

		public Int16? Version { get; set; }
	}
}
