using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Responses {
    /// <summary>
    /// 新闻列表
    /// </summary>
    public class NewsListResponse {
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
        public string title { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        /// <value></value>
        public string source { get; set; }
        /// <summary>
        /// 广告调整地址
        /// </summary>
        public string curl { get; set; }
        /// <summary>
        /// 缩略图列表（用于列表页显示图片），以∮分割
        /// </summary>
        /// <value></value>
        public string img { get; set; }
        /// <summary>
        /// 正常大小，可规定指定大小（用于轮播等其他大图展示）
        /// </summary>
        /// <value></value>
        public string imgpath { get; set; }
        /// <summary>
        /// 是否热门（只是站点热门标识，不参与排序、或特定页显示靠前）
        /// </summary>
        /// <value>0不是，1是</value>
        public int? ishot { get; set; }
        /// <summary>
        /// 访问总数
        /// </summary>
        /// <value></value>
        public int? acount { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? ptime { get; set; }
    }
}
