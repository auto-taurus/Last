using System;
using System.Collections.ObjectModel;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberInfos : IEntity
	{
		public MemberInfos()
		{
		}

		public MemberInfos(Int32? memberId)
		{
			MemberId = memberId;
		}

		public Int32? MemberId { get; set; }

		public String Code { get; set; }

		public String NickName { get; set; }

		public String Name { get; set; }

		public Int32? Sex { get; set; }

		public String Phone { get; set; }

		public String Alipay { get; set; }

		public String Wechat { get; set; }

		public String Password { get; set; }

		public String Avatar { get; set; }

		public Int32? Beans { get; set; }

		public Int32? BeansTotals { get; set; }

		public DateTime? LastLoginTime { get; set; }

		public Int32? NewsNumber { get; set; }

		public Int32? FollowNumber { get; set; }

		public Int32? FavoritesNumber { get; set; }

		public Int32? FansNumber { get; set; }

		public Int32? IsEnbale { get; set; }

		public String Remarks { get; set; }

		public DateTime? CreateTime { get; set; }

		public Collection<MemberFans> MemberFans { get; set; }

		public Collection<MemberFavorites> MemberFavorites { get; set; }

		public Collection<MemberFollow> MemberFollows { get; set; }

		public Collection<MemberFootprint> MemberFootprints { get; set; }

		public Collection<MemberIncome> MemberIncomes { get; set; }

		public Collection<MemberMessage> MemberMessages { get; set; }

		public Collection<MemberWithdraw> MemberWithdraws { get; set; }
	}
}
