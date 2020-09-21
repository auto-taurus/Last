using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemMenu : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_menuId;
		private Int32? m_siteNo;
		private String m_menuIcon;
		private String m_menuName;
		private Int32? m_parentId;
		private String m_nodeValue;
		private String m_areas;
		private String m_controller;
		private String m_action;
		private String m_urls;
		private String m_routerName;
		private String m_routerPath;
		private String m_component;
		private Int32? m_showAlways;
		private Int32? m_showHeader;
		private Int32? m_hideInBread;
		private Int32? m_hideInMenu;
		private Int32? m_notCache;
		private Int32? m_beforeCloseName;
		private Int32? m_sequence;
		private Int32? m_isEnable;
		private Byte[] m_timestamp;
		private String m_remarks;
		private Int32? m_createBy;
		private DateTime? m_createTime;

		public SystemMenu()
		{
		}

		public SystemMenu(Int32? menuId)
		{
			MenuId = menuId;
		}

		public Int32? MenuId
		{
			get
			{
				return m_menuId;
			}
			set
			{
				if (m_menuId != value)
				{
					m_menuId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MenuId)));
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

		public String MenuIcon
		{
			get
			{
				return m_menuIcon;
			}
			set
			{
				if (m_menuIcon != value)
				{
					m_menuIcon = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MenuIcon)));
				}
			}
		}

		public String MenuName
		{
			get
			{
				return m_menuName;
			}
			set
			{
				if (m_menuName != value)
				{
					m_menuName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MenuName)));
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

		public String Areas
		{
			get
			{
				return m_areas;
			}
			set
			{
				if (m_areas != value)
				{
					m_areas = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Areas)));
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

		public String RouterName
		{
			get
			{
				return m_routerName;
			}
			set
			{
				if (m_routerName != value)
				{
					m_routerName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RouterName)));
				}
			}
		}

		public String RouterPath
		{
			get
			{
				return m_routerPath;
			}
			set
			{
				if (m_routerPath != value)
				{
					m_routerPath = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RouterPath)));
				}
			}
		}

		public String Component
		{
			get
			{
				return m_component;
			}
			set
			{
				if (m_component != value)
				{
					m_component = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Component)));
				}
			}
		}

		public Int32? ShowAlways
		{
			get
			{
				return m_showAlways;
			}
			set
			{
				if (m_showAlways != value)
				{
					m_showAlways = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ShowAlways)));
				}
			}
		}

		public Int32? ShowHeader
		{
			get
			{
				return m_showHeader;
			}
			set
			{
				if (m_showHeader != value)
				{
					m_showHeader = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ShowHeader)));
				}
			}
		}

		public Int32? HideInBread
		{
			get
			{
				return m_hideInBread;
			}
			set
			{
				if (m_hideInBread != value)
				{
					m_hideInBread = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HideInBread)));
				}
			}
		}

		public Int32? HideInMenu
		{
			get
			{
				return m_hideInMenu;
			}
			set
			{
				if (m_hideInMenu != value)
				{
					m_hideInMenu = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(HideInMenu)));
				}
			}
		}

		public Int32? NotCache
		{
			get
			{
				return m_notCache;
			}
			set
			{
				if (m_notCache != value)
				{
					m_notCache = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NotCache)));
				}
			}
		}

		public Int32? BeforeCloseName
		{
			get
			{
				return m_beforeCloseName;
			}
			set
			{
				if (m_beforeCloseName != value)
				{
					m_beforeCloseName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BeforeCloseName)));
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
	}
}
