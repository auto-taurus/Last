using System;
using System.ComponentModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemRoleInDictionary : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_id;
		private Int32? m_roleId;
		private String m_dictionaryKey;
		private String m_dictionaryValue;

		public SystemRoleInDictionary()
		{
		}

		public SystemRoleInDictionary(Int32? id)
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

		public Int32? RoleId
		{
			get
			{
				return m_roleId;
			}
			set
			{
				if (m_roleId != value)
				{
					m_roleId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RoleId)));
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

		public SystemRole SystemRoleFk { get; set; }
	}
}
