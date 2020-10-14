using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class MemberInfo
    {
        public MemberInfo()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int MemberId { get; set; }

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

        public int? IsEnbale { get; set; }

        public string Remarks { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
