using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemDictionary : IEntity
	{
		public SystemDictionary()
		{
		}

		public SystemDictionary(Int32? dictionaryId)
		{
			DictionaryId = dictionaryId;
		}

		public Int32? DictionaryId { get; set; }

		public String TypeKey { get; set; }

		public String DistKey { get; set; }

		public String DistName { get; set; }

		public String DistValue { get; set; }

		public Int32? Sequence { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }
	}
}
