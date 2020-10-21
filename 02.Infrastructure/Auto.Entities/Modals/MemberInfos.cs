using System;
using System.Collections.Generic;

namespace Auto.Entities.Modals {
    public partial class MemberInfos {
        public MemberInfos() {
            #region Generated Constructor
            MemberFans = new HashSet<MemberFans>();
            MemberFavorites = new HashSet<MemberFavorites>();
            MemberFollows = new HashSet<MemberFollow>();
            MemberFootprints = new HashSet<MemberFootprint>();
            MemberIncomes = new HashSet<MemberIncome>();
            MemberMessages = new HashSet<MemberMessage>();
            MemberWithdraws = new HashSet<MemberWithdraw>();
            #endregion
        }

        #region Generated Properties
        public int MemberId { get; set; }

        public string Code { get; set; }

        public string NickName { get; set; }

        public string Name { get; set; }

        public int? Sex { get; set; }

        public string Phone { get; set; }

        public string Alipay { get; set; }

        public string Wechat { get; set; }

        public string Password { get; set; }

        public string Avatar { get; set; }

        public int? Beans { get; set; }

        public int? BeansTotals { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public int? NewsNumber { get; set; }

        public int? FollowNumber { get; set; }

        public int? FavoritesNumber { get; set; }

        public int? FansNumber { get; set; }
        public int? IsNew { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<MemberFans> MemberFans { get; set; }

        public virtual ICollection<MemberFavorites> MemberFavorites { get; set; }

        public virtual ICollection<MemberFollow> MemberFollows { get; set; }

        public virtual ICollection<MemberFootprint> MemberFootprints { get; set; }

        public virtual ICollection<MemberIncome> MemberIncomes { get; set; }

        public virtual ICollection<MemberMessage> MemberMessages { get; set; }

        public virtual ICollection<MemberWithdraw> MemberWithdraws { get; set; }

        #endregion

    }
}
