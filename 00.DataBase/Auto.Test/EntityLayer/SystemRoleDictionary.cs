using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemRoleDictionary : IEntity
	{
		public SystemRoleDictionary()
		{
		}

		public SystemRoleDictionary(Int32? id)
		{
			Id = id;
		}

		public Int32? Id { get; set; }

		public Int32? RoleId { get; set; }

		public String DictionaryKey { get; set; }

		public String DictionaryValue { get; set; }

		public SystemRole SystemRoleFk { get; set; }
	}
}
