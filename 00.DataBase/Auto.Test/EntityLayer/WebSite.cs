using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebSite : IEntity
	{
		public WebSite()
		{
		}

		public WebSite(Int32? siteId)
		{
			SiteId = siteId;
		}

		public Int32? SiteId { get; set; }

		public String SiteName { get; set; }

		public String SiteUrls { get; set; }

		public String LogoUrls { get; set; }

		public Int32? AccessNumber { get; set; }

		public String Title { get; set; }

		public String Keywords { get; set; }

		public String Description { get; set; }

		public Byte[] RowVers { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
