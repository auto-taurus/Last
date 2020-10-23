using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MSreplicationOptions : IEntity
	{
		public MSreplicationOptions()
		{
		}

		public object Optname { get; set; }

		public Boolean? Value { get; set; }

		public Int32? MajorVersion { get; set; }

		public Int32? MinorVersion { get; set; }

		public Int32? Revision { get; set; }

		public Int32? InstallFailures { get; set; }
	}
}
