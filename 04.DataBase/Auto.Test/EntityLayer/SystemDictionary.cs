using System;
using System.ComponentModel;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemDictionary : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_dictionaryId;
		private String m_keys;
		private String m_name;
		private String m_value;
		private String m_remarks;

		public SystemDictionary()
		{
		}

		public SystemDictionary(Int32? dictionaryId)
		{
			DictionaryId = dictionaryId;
		}

		public Int32? DictionaryId
		{
			get
			{
				return m_dictionaryId;
			}
			set
			{
				if (m_dictionaryId != value)
				{
					m_dictionaryId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DictionaryId)));
				}
			}
		}

		public String Keys
		{
			get
			{
				return m_keys;
			}
			set
			{
				if (m_keys != value)
				{
					m_keys = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Keys)));
				}
			}
		}

		public String Name
		{
			get
			{
				return m_name;
			}
			set
			{
				if (m_name != value)
				{
					m_name = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
				}
			}
		}

		public String Value
		{
			get
			{
				return m_value;
			}
			set
			{
				if (m_value != value)
				{
					m_value = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
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
	}
}
