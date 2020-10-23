using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SptFallbackDev : IEntity
	{
		public SptFallbackDev()
		{
		}

		public String XserverName { get; set; }

		public DateTime? XdttmIns { get; set; }

		public DateTime? XdttmLastInsUpd { get; set; }

		public Int32? XfallbackLow { get; set; }

		public String XfallbackDrive { get; set; }

		public Int32? Low { get; set; }

		public Int32? High { get; set; }

		public Int16? Status { get; set; }

		public String Name { get; set; }

		public String Phyname { get; set; }
	}
}
