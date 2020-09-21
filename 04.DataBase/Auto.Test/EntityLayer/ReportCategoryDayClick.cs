using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class ReportCategoryDayClick : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_categoryClickId;
		private Int32? m_categoryId;
		private String m_categoryName;
		private Int32? m_count;
		private DateTime? m_today;
		private DateTime? m_lastUpdateTime;

		public ReportCategoryDayClick()
		{
		}

		public ReportCategoryDayClick(Int32? categoryClickId)
		{
			CategoryClickId = categoryClickId;
		}

		public Int32? CategoryClickId
		{
			get
			{
				return m_categoryClickId;
			}
			set
			{
				if (m_categoryClickId != value)
				{
					m_categoryClickId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CategoryClickId)));
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
