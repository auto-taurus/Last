using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebNewsSensitive : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_newsSensitiveId;
		private Int32? m_siteMark;
		private Int32? m_newId;
		private String m_newTitleRecords;
		private String m_customTitleRecords;
		private String m_contentsRecords;
		private Int32? m_isEnable;
		private String m_remarks;
		private Int32? m_createBy;
		private DateTime? m_createTime;

		public WebNewsSensitive()
		{
		}

		public WebNewsSensitive(Int32? newsSensitiveId)
		{
			NewsSensitiveId = newsSensitiveId;
		}

		public Int32? NewsSensitiveId
		{
			get
			{
				return m_newsSensitiveId;
			}
			set
			{
				if (m_newsSensitiveId != value)
				{
					m_newsSensitiveId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewsSensitiveId)));
				}
			}
		}

		public Int32? SiteMark
		{
			get
			{
				return m_siteMark;
			}
			set
			{
				if (m_siteMark != value)
				{
					m_siteMark = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SiteMark)));
				}
			}
		}

		public Int32? NewId
		{
			get
			{
				return m_newId;
			}
			set
			{
				if (m_newId != value)
				{
					m_newId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewId)));
				}
			}
		}

		public String NewTitleRecords
		{
			get
			{
				return m_newTitleRecords;
			}
			set
			{
				if (m_newTitleRecords != value)
				{
					m_newTitleRecords = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewTitleRecords)));
				}
			}
		}

		public String CustomTitleRecords
		{
			get
			{
				return m_customTitleRecords;
			}
			set
			{
				if (m_customTitleRecords != value)
				{
					m_customTitleRecords = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CustomTitleRecords)));
				}
			}
		}

		public String ContentsRecords
		{
			get
			{
				return m_contentsRecords;
			}
			set
			{
				if (m_contentsRecords != value)
				{
					m_contentsRecords = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ContentsRecords)));
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
