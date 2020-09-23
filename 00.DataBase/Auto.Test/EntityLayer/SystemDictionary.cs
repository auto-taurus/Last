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

		public String Keys { get; set; }

		public String Name { get; set; }

		public String Value { get; set; }

		public String Remarks { get; set; }
	}
}
