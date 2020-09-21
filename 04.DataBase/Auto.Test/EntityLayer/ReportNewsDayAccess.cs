using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class ReportNewsDayAccess : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_newsAccessId;
		private Int32? m_newsId;
		private Int32? m_categoryId;
		private String m_categoryName;
		private Int32? m_specialCode;
		private String m_specialName;
		private Int32? m_count;
		private DateTime? m_today;
		private DateTime? m_lastUpdateTime;

		public ReportNewsDayAccess()
		{
		}

		public ReportNewsDayAccess(Int32? newsAccessId)
		{
			NewsAccessId = newsAccessId;
		}

		public Int32? NewsAccessId
		{
			get
			{
				return m_newsAccessId;
			}
			set
			{
				if (m_newsAccessId != value)
				{
					m_newsAccessId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NewsAccessId)));
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

		public Int32? SpecialCode
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

		public String SpecialName
		{
			get
			{
				return m_specialName;
			}
			set
			{
				if (m_specialName != value)
				{
					m_specialName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SpecialName)));
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

		public DateTime? Today
		{
			get
			{
				return m_today;
			}
			set
			{
				if (m_today != value)
				{
					m_today = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Today)));
				}
			}
		}

		public DateTime? LastUpdateTime
		{
			get
			{
				return m_lastUpdateTime;
			}
			set
			{
				if (m_lastUpdateTime != value)
				{
					m_lastUpdateTime = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastUpdateTime)));
				}
			}
		}
	}
}
