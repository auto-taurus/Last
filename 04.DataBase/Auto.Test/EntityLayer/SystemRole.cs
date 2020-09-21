using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class SystemRole : INotifyPropertyChanged, IEntity
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Int32? m_roleId;
		private String m_roleName;
		private Int32? m_isEnable;
		private String m_remarks;
		private Int32? m_createBy;
		private DateTime? m_createDate;

		public SystemRole()
		{
		}

		public SystemRole(Int32? roleId)
		{
			RoleId = roleId;
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

		public String RoleName
		{
			get
			{
				return m_roleName;
			}
			set
			{
				if (m_roleName != value)
				{
					m_roleName = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RoleName)));
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

		public DateTime? CreateDate
		{
			get
			{
				return m_createDate;
			}
			set
			{
				if (m_createDate != value)
				{
					m_createDate = value;
				
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CreateDate)));
				}
			}
		}

		public Collection<SystemRoleInDictionary> SystemRoleInDictionaries { get; set; }
	}
}
