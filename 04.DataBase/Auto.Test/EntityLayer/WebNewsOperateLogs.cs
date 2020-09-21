using System;
using System.ComponentModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebNewsOperateLogs : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_newsOperateId;
		private Int32? m_newsId;
		private String m_operateType;
		private String m_operateStatus;
		private String m_remarks;
		private Int32? m_createBy;
		private String m_createName;
		private DateTime? m_createTime;

		public WebNewsOperateLogs()
		{
		}

		public WebNewsOperateLogs(Int32? newsOperateId)
		{
			NewsOperateId = newsOperateId;
		}

		public Int32? NewsOperateId
		{
			get
			{
				return m_newsOperateId;
			}
			set
			{
				if (m_newsOperateId != value)
				{
					m_newsOperateId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewsOperateId)));
				}
			}
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

		public String OperateType
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

		public String OperateStatus
		{
			get
			{
				return m_operateStatus;
			}
			set
			{
				if (m_operateStatus != value)
				{
					m_operateStatus = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OperateStatus)));
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

		public String CreateName
		{
			get
			{
				return m_createName;
			}
			set
			{
				if (m_createName != value)
				{
					m_createName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CreateName)));
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

		public WebNews WebNewsFk { get; set; }
	}
}
