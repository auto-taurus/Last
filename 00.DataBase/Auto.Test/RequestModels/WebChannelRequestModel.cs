using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class WebChannelRequestModel
	{
		[Key]
		public Int32? ChannelId { get; set; }

		public Int32? SiteNo { get; set; }

		[StringLength(100)]
		public String ChannelName { get; set; }

		[StringLength(1000)]
		public String ChannelAddress { get; set; }

		[StringLength(255)]
		public String ChannelJs { get; set; }

		public Int32? IsEnable { get; set; }

		public Byte[] RowVers { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
