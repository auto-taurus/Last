using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebSensitive : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_sensitiveId;
		private Int32? m_siteNo;
		private Int32? m_type;
		private String m_typeText;
		private String m_sensitiveWords;
		private String m_author;
		private String m_urls;
		private Byte[] m_timestamp;
		private Int32? m_isEnable;
		private String m_remarks;
		private Int32? m_createBy;
		private DateTime? m_createTime;

		public WebSensitive()
		{
		}

		public WebSensitive(Int32? sensitiveId)
		{
			SensitiveId = sensitiveId;
		}

		public Int32? SensitiveId
		{
			get
			{
				return m_sensitiveId;
			}
			set
			{
				if (m_sensitiveId != value)
				{
					m_sensitiveId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SensitiveId)));
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

		public Int32? Type
		{
			get
			{
				return m_type;
			}
			set
			{
				if (m_type != value)
				{
					m_type = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Type)));
				}
			}
		}

		public String TypeText
		{
			get
			{
				return m_typeText;
			}
			set
			{
				if (m_typeText != value)
				{
					m_typeText = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TypeText)));
				}
			}
		}

		public String SensitiveWords
		{
			get
			{
				return m_sensitiveWords;
			}
			set
			{
				if (m_sensitiveWords != value)
				{
					m_sensitiveWords = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SensitiveWords)));
				}
			}
		}

		public String Author
		{
			get
			{
				return m_author;
			}
			set
			{
				if (m_author != value)
				{
					m_author = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Author)));
				}
			}
		}

		public String Urls
		{
			get
			{
				return m_urls;
			}
			set
			{
				if (m_urls != value)
				{
					m_urls = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Urls)));
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
