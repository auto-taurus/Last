using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Entities.Dtos {
    public class MemberAppDto {

        public MemberAppDto() {
            this.TodayBeans = 0;
        }
        #region Generated Properties
        /// <summary>
        /// 
        /// </summary>
        public int MemberId { get; set; }

        public string Code { get; set; }

        public string NickName { get; set; }

        public string Name { get; set; }

        public int? Sex { get; set; }

        public string Phone { get; set; }
        /// <summary>
        /// 支付宝
        /// </summary>
        public string Alipay { get; set; }
        /// <summary>
        /// 微信
        /// </summary>
        public string Uid { get; set; }
        /// <summary>
        /// 微信
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }
        /// <summary>
        /// 剩余绿豆
        /// </summary>
        public int? Beans { get; set; }
        /// <summary>
        /// 累计绿豆
        /// </summary>
        public int? BeansTotals { get; set; }
        /// <summary>
        /// 是否已完成新手任务
        /// </summary>
        public int? IsNew { get; set; }

        #endregion

        #region Calculated Attributes
        /// <summary>
        /// 今日绿豆
        /// </summary>
        public int? TodayBeans { get; set; }
        /// <summary>
        /// 今日阅读(分钟)
        /// </summary>
        public int? TodayRead { get; set; }
        /// <summary>
        /// 比率
        /// </summary>
        public string Ratio { get; set; }

        /// <summary>
        /// 比率结果
        /// </summary>
        public decimal? RatioValue { get; set; }
        #endregion
    }
}
