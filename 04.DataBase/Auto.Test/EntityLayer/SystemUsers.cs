using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemUsers : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_usersId;
		private String m_usersName;
		private String m_loginName;
		private String m_password;
		private String m_mobilePhone;
		private String m_email;
		private String m_loginIp;
		private DateTime? m_loginTime;
		private Int32? m_isEnable;
		private String m_remarks;
		private Int32? m_createBy;
		private DateTime? m_createTime;

		public SystemUsers()
		{
		}

		public SystemUsers(Int32? usersId)
		{
			UsersId = usersId;
		}

		public Int32? UsersId
		{
			get
			{
				return m_usersId;
			}
			set
			{
				if (m_usersId != value)
				{
					m_usersId = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UsersId)));
				}
			}
		}

		public String UsersName
		{
			get
			{
				return m_usersName;
			}
			set
			{
				if (m_usersName != value)
				{
					m_usersName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UsersName)));
				}
			}
		}

		public String LoginName
		{
			get
			{
				return m_loginName;
			}
			set
			{
				if (m_loginName != value)
				{
					m_loginName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LoginName)));
				}
			}
		}

		public String Password
		{
			get
			{
				return m_password;
			}
			set
			{
				if (m_password != value)
				{
					m_password = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
				}
			}
		}

		public String MobilePhone
		{
			get
			{
				return m_mobilePhone;
			}
			set
			{
				if (m_mobilePhone != value)
				{
					m_mobilePhone = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MobilePhone)));
				}
			}
		}

		public String Email
		{
			get
			{
				return m_email;
			}
			set
			{
				if (m_email != value)
				{
					m_email = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
				}
			}
		}

		public String LoginIp
		{
			get
			{
				return m_loginIp;
			}
			set
			{
				if (m_loginIp != value)
				{
					m_loginIp = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LoginIp)));
				}
			}
		}

		public DateTime? LoginTime
		{
			get
			{
				return m_loginTime;
			}
			set
			{
				if (m_loginTime != value)
				{
					m_loginTime = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LoginTime)));
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

		public Collection<SystemUsersInDictionary> SystemUsersInDictionaries { get; set; }
	}
}
