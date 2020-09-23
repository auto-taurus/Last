using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebChannel : IEntity
	{
		public WebChannel()
		{
		}

		public WebChannel(Int32? channelId)
		{
			ChannelId = channelId;
		}

		public Int32? ChannelId { get; set; }

		public Int32? SiteNo { get; set; }

		public String ChannelName { get; set; }

		public String ChannelAddress { get; set; }

		public String ChannelJs { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] RowVers { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
