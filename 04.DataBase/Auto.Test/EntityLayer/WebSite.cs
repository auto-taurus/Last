using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebSite : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_siteId;
		private Int32? m_siteNo;
		private String m_siteName;
		private String m_siteUrls;
		private String m_logoUrls;
		private Int32? m_count;
		private String m_title;
		private String m_keywords;
		private String m_description;
		private Byte[] m_timestamp;
		private Int32? m_isEnable;
		private String m_remarks;
		private Int32? m_createBy;
		private DateTime? m_createTime;

		public WebSite()
		{
		}

		public WebSite(Int32? siteId)
		{
			SiteId = siteId;
		}

		public Int32? SiteId
		{
			get
			{
				return m_siteId;
			}
			set
			{
				if (m_siteId != value)
				{
					m_siteId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SiteId)));
				}
			}
		}

		public Int32? SiteNo
		{
			get
			{
				return m_siteNo;
			}
			set
			{
				if (m_siteNo != value)
				{
					m_siteNo = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SiteNo)));
				}
			}
		}

		public String SiteName
		{
			get
			{
				return m_siteName;
			}
			set
			{
				if (m_siteName != value)
				{
					m_siteName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SiteName)));
				}
			}
		}

		public String SiteUrls
		{
			get
			{
				return m_siteUrls;
			}
			set
			{
				if (m_siteUrls != value)
				{
					m_siteUrls = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SiteUrls)));
				}
			}
		}

		public String LogoUrls
		{
			get
			{
				return m_logoUrls;
			}
			set
			{
				if (m_logoUrls != value)
				{
					m_logoUrls = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LogoUrls)));
				}
			}
		}

		public Int32? Count
		{
			get
			{
				return m_count;
			}
			set
			{
				if (m_count != value)
				{
					m_count = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
				}
			}
		}

		public String Title
		{
			get
			{
				return m_title;
			}
			set
			{
				if (m_title != value)
				{
					m_title = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
				}
			}
		}

		public String Keywords
		{
			get
			{
				return m_keywords;
			}
			set
			{
				if (m_keywords != value)
				{
					m_keywords = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Keywords)));
				}
			}
		}

		public String Description
		{
			get
			{
				return m_description;
			}
			set
			{
				if (m_description != value)
				{
					m_description = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Description)));
				}
			}
		}

		public Byte[] Timestamp
		{
			get
			{
				return m_timestamp;
			}
			set
			{
				if (m_timestamp != value)
				{
					m_timestamp = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Timestamp)));
				}
			}
		}

		public Int32? IsEnable
		{
			get
			{
				return m_isEnable;
			}
			set
			{
				if (m_isEnable != value)
				{
					m_isEnable = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsEnable)));
				}
			}
		}

		public String Remarks
		{
			get
			{
				return m_remarks;
			}
			set
			{
				if (m_remarks != value)
				{
					m_remarks = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Remarks)));
				}
			}
		}

		public Int32? CreateBy
		{
			get
			{
				return m_createBy;
			}
			set
			{
				if (m_createBy != value)
				{
					m_createBy = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CreateBy)));
				}
			}
		}

		public DateTime? CreateTime
		{
			get
			{
				return m_createTime;
			}
			set
			{
				if (m_createTime != value)
				{
					m_createTime = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CreateTime)));
				}
			}
		}
	}
}
