using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Data {
    /// <summary>
    /// 新闻详情信息
    /// </summary>
    public class NewsResponse {
        /// <summary>
        /// 新闻编号
        /// </summary>
        /// <value></value>
        public string NewsId { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        /// <value></value>
        public int? CategoryId { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        /// <value></value>
        public string CategoryName { get; set; }
        /// <summary>
        /// 内容标题
        /// </summary>
        /// <value></value>
        public string NewsTitle { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        /// <value></value>
        public string Source { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        /// <value></value>
        public string Author { get; set; }
        /// <summary>
        /// 标签，以∮分割
        /// </summary>
        /// <value></value>
        public string Tags { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        /// <value></value>
        public string Contents { get; set; }
        /// <summary>
        /// 访问地址
        /// </summary>
        public string Curl { get; set; }
        /// <summary>
        /// 是否热门（只是站点热门标识，不参与排序、或特定页显示靠前）
        /// </summary>
        /// <value>0不是，1是</value>
        public int? IsHot { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? PushTime { get; set; }
        /// <summary>
        /// 网页标题
        /// </summary>
        /// <value></value>
        public string Title { get; set; }
        ///// <summary>
        ///// 网页关键字
        ///// </summary>
        ///// <value></value>
        //public string words { get; set; }
        ///// <summary>
        ///// 网页描述
        ///// </summary>
        ///// <value></value>
        //public string desc { get; set; }
    }
}
