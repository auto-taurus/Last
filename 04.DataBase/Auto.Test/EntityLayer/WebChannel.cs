using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class WebChannel : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_channelId;
		private Int32? m_siteNo;
		private String m_channelName;
		private String m_channelAddress;
		private String m_channelJs;
		private Int32? m_isEnable;
		private Byte[] m_timestamp;
		private String m_remarks;
		private Int32? m_createBy;
		private DateTime? m_createTime;

		public WebChannel()
		{
		}

		public WebChannel(Int32? channelId)
		{
			ChannelId = channelId;
		}

		public Int32? ChannelId
		{
			get
			{
				return m_channelId;
			}
			set
			{
				if (m_channelId != value)
				{
					m_channelId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChannelId)));
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

		public String ChannelName
		{
			get
			{
				return m_channelName;
			}
			set
			{
				if (m_channelName != value)
				{
					m_channelName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChannelName)));
				}
			}
		}

		public String ChannelAddress
		{
			get
			{
				return m_channelAddress;
			}
			set
			{
				if (m_channelAddress != value)
				{
					m_channelAddress = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChannelAddress)));
				}
			}
		}

		public String ChannelJs
		{
			get
			{
				return m_channelJs;
			}
			set
			{
				if (m_channelJs != value)
				{
					m_channelJs = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChannelJs)));
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
