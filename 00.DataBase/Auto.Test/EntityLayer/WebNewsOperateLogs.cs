using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebNewsOperateLogs : IEntity
	{
		public WebNewsOperateLogs()
		{
		}

		public WebNewsOperateLogs(Int32? newsOperateId)
		{
			NewsOperateId = newsOperateId;
		}

		public Int32? NewsOperateId { get; set; }

		public String NewsId { get; set; }

		public String OperateType { get; set; }

		public String OperateStatus { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public String CreateName { get; set; }

		public DateTime? CreateTime { get; set; }

		public WebNews WebNewsFk { get; set; }
	}
}
