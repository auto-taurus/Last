using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class AutoBatchInsertNewsId : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_id;
		private Int32? m_newsId;
		private String m_message;

		public AutoBatchInsertNewsId()
		{
		}

		public AutoBatchInsertNewsId(Int32? id)
		{
			Id = id;
		}

		public Int32? Id
		{
			get
			{
				return m_id;
			}
			set
			{
				if (m_id != value)
				{
					m_id = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
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

		public String Message
		{
			get
			{
				return m_message;
			}
			set
			{
				if (m_message != value)
				{
					m_message = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Message)));
				}
			}
		}
	}
}
