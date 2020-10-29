using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class MemberInfosUpdateModel
    {
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

        public int? IsEnbale { get; set; }

        public string Remarks { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
