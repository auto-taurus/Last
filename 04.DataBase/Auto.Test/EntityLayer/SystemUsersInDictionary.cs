using System;
using System.ComponentModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsersInDictionary : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_id;
		private Int32? m_userId;
		private String m_dictionaryKey;
		private String m_dictionaryValue;

		public SystemUsersInDictionary()
		{
		}

		public SystemUsersInDictionary(Int32? id)
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

		public Int32? UserId
		{
			get
			{
				return m_userId;
			}
			set
			{
				if (m_userId != value)
				{
					m_userId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserId)));
				}
			}
		}

		public String DictionaryKey
		{
			get
			{
				return m_dictionaryKey;
			}
			set
			{
				if (m_dictionaryKey != value)
				{
					m_dictionaryKey = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DictionaryKey)));
				}
			}
		}

		public String DictionaryValue
		{
			get
			{
				return m_dictionaryValue;
			}
			set
			{
				if (m_dictionaryValue != value)
				{
					m_dictionaryValue = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DictionaryValue)));
				}
			}
		}

		public SystemUsers SystemUsersFk { get; set; }
	}
}
