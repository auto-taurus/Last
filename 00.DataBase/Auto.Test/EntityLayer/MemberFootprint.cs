using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberFootprint : IEntity
	{
		public MemberFootprint()
		{
		}

		public MemberFootprint(Int32? footprintId)
		{
			FootprintId = footprintId;
		}

		public Int32? FootprintId { get; set; }

		public Int32? MemberId { get; set; }

		public String SourceId { get; set; }

		public String SourceTable { get; set; }

		public DateTime? BrowseTime { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public MemberInfos MemberInfosFk { get; set; }
	}
}
