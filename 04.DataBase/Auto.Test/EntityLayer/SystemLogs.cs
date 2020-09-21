using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemLogs : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_logsId;
		private String m_methods;
		private Int32? m_grade;
		private String m_source;
		private String m_args;
		private String m_errors;
		private Int32? m_createBy;
		private DateTime? m_createTime;

		public SystemLogs()
		{
		}

		public SystemLogs(Int32? logsId)
		{
			LogsId = logsId;
		}

		public Int32? LogsId
		{
			get
			{
				return m_logsId;
			}
			set
			{
				if (m_logsId != value)
				{
					m_logsId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LogsId)));
				}
			}
		}

		public String Methods
		{
			get
			{
				return m_methods;
			}
			set
			{
				if (m_methods != value)
				{
					m_methods = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Methods)));
				}
			}
		}

		public Int32? Grade
		{
			get
			{
				return m_grade;
			}
			set
			{
				if (m_grade != value)
				{
					m_grade = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Grade)));
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

		public String Args
		{
			get
			{
				return m_args;
			}
			set
			{
				if (m_args != value)
				{
					m_args = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Args)));
				}
			}
		}

		public String Errors
		{
			get
			{
				return m_errors;
			}
			set
			{
				if (m_errors != value)
				{
					m_errors = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Errors)));
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
