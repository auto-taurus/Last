using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Responses {
    /// <summary>
    /// 新闻详情信息
    /// </summary>
    public class NewsResponse {
        /// <summary>
        /// 新闻编号
        /// </summary>
        /// <value></value>
        public int? nid { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        /// <value></value>
        public int? cid { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        /// <value></value>
        public string cname { get; set; }
        /// <summary>
        /// 内容标题
        /// </summary>
        /// <value></value>
        public string ntitle { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        /// <value></value>
        public string source { get; set; }
        /// <summary>
        /// 标签，以∮分割
        /// </summary>
        /// <value></value>
        public string tags { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        /// <value></value>
        public string contents { get; set; }
        /// <summary>
        /// 访问地址
        /// </summary>
        public string curl { get; set; }
        /// <summary>
        /// 是否热门（只是站点热门标识，不参与排序、或特定页显示靠前）
        /// </summary>
        /// <value>0不是，1是</value>
        public int? ishot { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? ptime { get; set; }
        /// <summary>
        /// 网页标题
        /// </summary>
        /// <value></value>
        public string title { get; set; }
        /// <summary>
        /// 网页关键字
        /// </summary>
        /// <value></value>
        public string words { get; set; }
        /// <summary>
        /// 网页描述
        /// </summary>
        /// <value></value>
        public string desc { get; set; }
    }
}
