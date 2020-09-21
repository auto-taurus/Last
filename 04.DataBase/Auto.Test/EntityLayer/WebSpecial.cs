using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebSpecial : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_specialId;
		private Int32? m_siteNo;
		private String m_specialCode;
		private String m_name;
		private Int32? m_displayType;
		private Int32? m_isEnable;
		private Byte[] m_timestamp;
		private String m_remarks;
		private Int32? m_createBy;
		private DateTime? m_createTime;

		public WebSpecial()
		{
		}

		public Int32? SpecialId
		{
			get
			{
				return m_specialId;
			}
			set
			{
				if (m_specialId != value)
				{
					m_specialId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialId)));
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

		public String SpecialCode
		{
			get
			{
				return m_specialCode;
			}
			set
			{
				if (m_specialCode != value)
				{
					m_specialCode = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialCode)));
				}
			}
		}

		public String Name
		{
			get
			{
				return m_name;
			}
			set
			{
				if (m_name != value)
				{
					m_name = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
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
