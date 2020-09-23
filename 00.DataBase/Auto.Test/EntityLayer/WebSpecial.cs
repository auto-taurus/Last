using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebSpecial : IEntity
	{
		public WebSpecial()
		{
		}

		public WebSpecial(Int32? specialId)
		{
			SpecialId = specialId;
		}

		public Int32? SpecialId { get; set; }

		public Int32? SiteNo { get; set; }

		public String SpecialCode { get; set; }

		public String Name { get; set; }

		public Int32? DisplayType { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] RowVers { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
