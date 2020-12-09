using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Data {
    /// <summary>
    /// 新闻列表
    /// </summary>
    public class NewsListResponse {
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
        public string Author { get; set; }
        /// <summary>
        /// 广告调整地址
        /// </summary>
        public string Curl { get; set; }
        /// <summary>
        /// 缩略图列表（用于列表页显示图片），以∮分割
        /// </summary>
        /// <value></value>
        public string Img { get; set; }
        /// <summary>
        /// 正常大小，可规定指定大小（用于轮播等其他大图展示）
        /// </summary>
        /// <value></value>
        public string ImagePath { get; set; }
        /// <summary>
        /// 显示类型，前台独立位置显示
        /// </summary>
        /// <value>0默认值，1置顶</value>
        public int? DisplayType { get; set; }
        /// <summary>
        /// 是否热门（只是站点热门标识，不参与排序、或特定页显示靠前）
        /// </summary>
        /// <value>0不是，1是</value>
        public int? IsHot { get; set; }
        /// <summary>
        /// 访问总数
        /// </summary>
        /// <value></value>
        public int? AccessCount { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? PushTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? Creatime { get; set; }
    }
}
