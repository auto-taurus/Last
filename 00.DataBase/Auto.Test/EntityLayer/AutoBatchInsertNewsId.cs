using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class AutoBatchInsertNewsId : IEntity
	{
		public AutoBatchInsertNewsId()
		{
		}

		public AutoBatchInsertNewsId(Int32? id)
		{
			Id = id;
		}

		public Int32? Id { get; set; }

		public Int32? NewsId { get; set; }

		public String Message { get; set; }
	}
}
