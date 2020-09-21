using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class ReportSiteDayAccess : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_siteAccessId;
		private String m_siteNo;
		private Int32? m_count;
		private DateTime? m_today;
		private DateTime? m_lastUpdateTime;

		public ReportSiteDayAccess()
		{
		}

		public ReportSiteDayAccess(Int32? siteAccessId)
		{
			SiteAccessId = siteAccessId;
		}

		public Int32? SiteAccessId
		{
			get
			{
				return m_siteAccessId;
			}
			set
			{
				if (m_siteAccessId != value)
				{
					m_siteAccessId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SiteAccessId)));
				}
			}
		}

		public String SiteNo
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
