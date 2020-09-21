using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebCategory : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_categoryId;
		private Int32? m_siteNo;
		private String m_categoryName;
		private Int32? m_parentId;
		private String m_nodeValue;
		private String m_controller;
		private String m_action;
		private String m_urls;
		private Int32? m_documentNumber;
		private Int32? m_virtualAccessNumber;
		private Int32? m_accessNumber;
		private Int32? m_clickNumber;
		private String m_title;
		private String m_keywords;
		private String m_description;
		private Int32? m_sequence;
		private Int32? m_isEnable;
		private Byte[] m_timestamp;
		private String m_remarks;
		private Int32? m_createBy;
		private DateTime? m_createTime;

		public WebCategory()
		{
		}

		public WebCategory(Int32? categoryId)
		{
			CategoryId = categoryId;
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

		public Int32? ParentId
		{
			get
			{
				return m_parentId;
			}
			set
			{
				if (m_parentId != value)
				{
					m_parentId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ParentId)));
				}
			}
		}

		public String NodeValue
		{
			get
			{
				return m_nodeValue;
			}
			set
			{
				if (m_nodeValue != value)
				{
					m_nodeValue = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NodeValue)));
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

		public Int32? DocumentNumber
		{
			get
			{
				return m_documentNumber;
			}
			set
			{
				if (m_documentNumber != value)
				{
					m_documentNumber = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DocumentNumber)));
				}
			}
		}

		public Int32? VirtualAccessNumber
		{
			get
			{
				return m_virtualAccessNumber;
			}
			set
			{
				if (m_virtualAccessNumber != value)
				{
					m_virtualAccessNumber = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VirtualAccessNumber)));
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

		public Collection<WebNews> WebNews { get; set; }
	}
}
