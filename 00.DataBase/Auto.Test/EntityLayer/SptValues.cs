using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SptValues
	{
		public SptValues()
		{
		}

		public String Name { get; set; }

		public Int32? Number { get; set; }

		public String Type { get; set; }

		public Int32? Low { get; set; }

		public Int32? High { get; set; }

		public Int32? Status { get; set; }
	}
}
