using System;
using System.ComponentModel;
using OnLineStoreCore.EntityLayer;
using System.Collections.ObjectModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebNews : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_newsId;
		private Int32? m_siteId;
		private Int32? m_categoryId;
		private String m_categoryName;
		private String m_newsTitle;
		private String m_customTitle;
		private String m_source;
		private String m_sourceAddress;
		private String m_sourceLogo;
		private String m_tags;
		private String m_contents;
		private String m_controller;
		private String m_action;
		private String m_urls;
		private String m_imageThums;
		private String m_imagePaths;
		private Int32? m_displayType;
		private Int32? m_isHot;
		private String m_title;
		private String m_keywords;
		private String m_description;
		private Int32? m_accessNumber;
		private Int32? m_clickNumber;
		private String m_auditName;
		private Int32? m_auditStatus;
		private DateTime? m_auditTime;
		private Int32? m_pushStatus;
		private String m_pushName;
		private DateTime? m_pushTime;
		private Int32? m_operateType;
		private Int32? m_categorySort;
		private Int32? m_singleSort;
		private Int32? m_sequence;
		private Int32? m_isEnable;
		private Byte[] m_timestamp;
		private String m_remarks;
		private Int32? m_createBy;
		private DateTime? m_createTime;

		public WebNews()
		{
		}

		public WebNews(Int32? newsId)
		{
			NewsId = newsId;
		}

		public Int32? NewsId
		{
			get
			{
				return m_newsId;
			}
			set
			{
				if (m_newsId != value)
				{
					m_newsId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewsId)));
				}
			}
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

		public Int32? CategoryId
		{
			get
			{
				return m_categoryId;
			}
			set
			{
				if (m_categoryId != value)
				{
					m_categoryId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CategoryId)));
				}
			}
		}

		public String CategoryName
		{
			get
			{
				return m_categoryName;
			}
			set
			{
				if (m_categoryName != value)
				{
					m_categoryName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CategoryName)));
				}
			}
		}

		public String NewsTitle
		{
			get
			{
				return m_newsTitle;
			}
			set
			{
				if (m_newsTitle != value)
				{
					m_newsTitle = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewsTitle)));
				}
			}
		}

		public String CustomTitle
		{
			get
			{
				return m_customTitle;
			}
			set
			{
				if (m_customTitle != value)
				{
					m_customTitle = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomTitle)));
				}
			}
		}

		public String Source
		{
			get
			{
				return m_source;
			}
			set
			{
				if (m_source != value)
				{
					m_source = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Source)));
				}
			}
		}

		public String SourceAddress
		{
			get
			{
				return m_sourceAddress;
			}
			set
			{
				if (m_sourceAddress != value)
				{
					m_sourceAddress = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SourceAddress)));
				}
			}
		}

		public String SourceLogo
		{
			get
			{
				return m_sourceLogo;
			}
			set
			{
				if (m_sourceLogo != value)
				{
					m_sourceLogo = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SourceLogo)));
				}
			}
		}

		public String Tags
		{
			get
			{
				return m_tags;
			}
			set
			{
				if (m_tags != value)
				{
					m_tags = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Tags)));
				}
			}
		}

		public String Contents
		{
			get
			{
				return m_contents;
			}
			set
			{
				if (m_contents != value)
				{
					m_contents = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Contents)));
				}
			}
		}

		public String Controller
		{
			get
			{
				return m_controller;
			}
			set
			{
				if (m_controller != value)
				{
					m_controller = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Controller)));
				}
			}
		}

		public String Action
		{
			get
			{
				return m_action;
			}
			set
			{
				if (m_action != value)
				{
					m_action = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Action)));
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

		public String ImageThums
		{
			get
			{
				return m_imageThums;
			}
			set
			{
				if (m_imageThums != value)
				{
					m_imageThums = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImageThums)));
				}
			}
		}

		public String ImagePaths
		{
			get
			{
				return m_imagePaths;
			}
			set
			{
				if (m_imagePaths != value)
				{
					m_imagePaths = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ImagePaths)));
				}
			}
		}

		public Int32? DisplayType
		{
			get
			{
				return m_displayType;
			}
			set
			{
				if (m_displayType != value)
				{
					m_displayType = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DisplayType)));
				}
			}
		}

		public Int32? IsHot
		{
			get
			{
				return m_isHot;
			}
			set
			{
				if (m_isHot != value)
				{
					m_isHot = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsHot)));
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

		public Int32? AccessNumber
		{
			get
			{
				return m_accessNumber;
			}
			set
			{
				if (m_accessNumber != value)
				{
					m_accessNumber = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AccessNumber)));
				}
			}
		}

		public Int32? ClickNumber
		{
			get
			{
				return m_clickNumber;
			}
			set
			{
				if (m_clickNumber != value)
				{
					m_clickNumber = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ClickNumber)));
				}
			}
		}

		public String AuditName
		{
			get
			{
				return m_auditName;
			}
			set
			{
				if (m_auditName != value)
				{
					m_auditName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AuditName)));
				}
			}
		}

		public Int32? AuditStatus
		{
			get
			{
				return m_auditStatus;
			}
			set
			{
				if (m_auditStatus != value)
				{
					m_auditStatus = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AuditStatus)));
				}
			}
		}

		public DateTime? AuditTime
		{
			get
			{
				return m_auditTime;
			}
			set
			{
				if (m_auditTime != value)
				{
					m_auditTime = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AuditTime)));
				}
			}
		}

		public Int32? PushStatus
		{
			get
			{
				return m_pushStatus;
			}
			set
			{
				if (m_pushStatus != value)
				{
					m_pushStatus = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PushStatus)));
				}
			}
		}

		public String PushName
		{
			get
			{
				return m_pushName;
			}
			set
			{
				if (m_pushName != value)
				{
					m_pushName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PushName)));
				}
			}
		}

		public DateTime? PushTime
		{
			get
			{
				return m_pushTime;
			}
			set
			{
				if (m_pushTime != value)
				{
					m_pushTime = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PushTime)));
				}
			}
		}

		public Int32? OperateType
		{
			get
			{
				return m_operateType;
			}
			set
			{
				if (m_operateType != value)
				{
					m_operateType = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OperateType)));
				}
			}
		}

		public Int32? CategorySort
		{
			get
			{
				return m_categorySort;
			}
			set
			{
				if (m_categorySort != value)
				{
					m_categorySort = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CategorySort)));
				}
			}
		}

		public Int32? SingleSort
		{
			get
			{
				return m_singleSort;
			}
			set
			{
				if (m_singleSort != value)
				{
					m_singleSort = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SingleSort)));
				}
			}
		}

		public Int32? Sequence
		{
			get
			{
				return m_sequence;
			}
			set
			{
				if (m_sequence != value)
				{
					m_sequence = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Sequence)));
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

		public WebCategory WebCategoryFk { get; set; }

		public Collection<WebNewsOperateLogs> WebNewsOperateLogs { get; set; }
	}
}
