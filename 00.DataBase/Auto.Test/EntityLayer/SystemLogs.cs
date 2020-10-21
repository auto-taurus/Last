using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemLogs : IEntity
	{
		public SystemLogs()
		{
		}

		public SystemLogs(Int32? logsId)
		{
			LogsId = logsId;
		}

		public Int32? LogsId { get; set; }

		public String Methods { get; set; }

		public Int32? Grade { get; set; }

		public String Source { get; set; }

		public String Args { get; set; }

		public String Errors { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
