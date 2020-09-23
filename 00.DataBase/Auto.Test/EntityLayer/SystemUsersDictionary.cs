using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsersDictionary : IEntity
	{
		public SystemUsersDictionary()
		{
		}

		public SystemUsersDictionary(Int32? id)
		{
			Id = id;
		}

		public Int32? Id { get; set; }

		public Int32? UserId { get; set; }

		public String DictionaryKey { get; set; }

		public String DictionaryValue { get; set; }

		public SystemUsers SystemUsersFk { get; set; }
	}
}
