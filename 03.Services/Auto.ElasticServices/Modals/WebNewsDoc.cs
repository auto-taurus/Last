using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.ElasticServices.Modals {
    /// <summary>
    /// 内容文档
    /// _doc中得_id为NewsId
    /// </summary>
    [ElasticsearchType(IdProperty = "NewsId")]
    public class WebNewsDoc {
        public WebNewsDoc() {
            Tags = new List<String>();
        }
        ///// <summary>
        ///// 站点标识
        ///// </summary>
        [Number(Index = true)]
        public int? SiteId { get; set; }
        /// <summary>
        /// 新闻编号
        /// </summary>
        /// <value></value>
        [Keyword(Index = true, IgnoreAbove = 12)]
        public string NewsId { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        /// <value></value>
        [Number(Index = true)]
        public int? CategoryId { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        /// <value></value>
        [Keyword(Index = true)]
        public string CategoryName { get; set; }
        /// <summary>
        /// 专栏代码
        /// </summary>
        /// <value></value>
        [Keyword(Index = true)]
        public string SpecialCode { get; set; }
        /// <summary>
        /// 内容标题
        /// </summary>
        /// <value></value>
        [Text(Index = true, Analyzer = "ik_smart")]
        public string NewsTitle { get; set; }
        /// <summary>
        /// 来源编号
        /// </summary>
        /// <value></value>
        [Keyword(Index = true)]
        public string SourceId { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        /// <value></value>
        [Keyword(Index = true)]
        public string Source { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        /// <value></value>
        [Keyword(Index = true)]
        public string Author { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        /// <value></value>
        public IList<String> Tags { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        /// <value></value>
        [Text(Index = true)]
        public string Contents { get; set; }
        /// <summary>
        /// 访问地址
        /// </summary>
        [Text(Index = false)]
        public string Curl { get; set; }
        /// <summary>
        /// 缩略图列表（用于列表页显示图片），以∮分割
        /// </summary>
        /// <value></value>
        [Text(Index = false)]
        public string Img { get; set; }
        /// <summary>
        /// 正常大小，可规定指定大小（用于轮播等其他大图展示）
        /// </summary>
        /// <value></value>
        [Text(Index = false)]
        public string ImagePath { get; set; }
        /// <summary>
        /// 显示类型，前台独立位置显示
        /// </summary>
        /// <value>0默认值，1置顶</value>
        [Number(Index = true)]
        public int? DisplayType { get; set; }
        /// <summary>
        /// 是否热门（只是站点热门标识，不参与排序、或特定页显示靠前）
        /// </summary>
        /// <value>0不是，1是</value>
        [Number(Index = true)]
        public int? IsHot { get; set; }
        /// <summary>
        /// 访问总数
        /// </summary>
        /// <value></value>
        [Number(Index = true)]
        public int? AccessCount { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        //[Date(Index = true)]
        [Date(Index = true)]
        public DateTime? PushTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Date(Index = true)]
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 分类排序
        /// </summary>
        [Number(Index = false)]
        public int? CategorySort { get; set; }
        /// <summary>
        /// 专栏排序
        /// </summary>
        [Number(Index = false)]
        public int? SpecialSort { get; set; }
        /// <summary>
        /// 总排序
        /// </summary>
        [Number(Index = false)]
        public int? Sequence { get; set; }
        ///// <summary>
        ///// 网页标题
        ///// </summary>
        ///// <value></value>
        //[Keyword(Index = false)]
        //public string Title { get; set; }
        ///// <summary>
        ///// 网页关键字
        ///// </summary>
        ///// <value></value>
        //[Keyword(Index = false)]
        //public string Keywords { get; set; }
        ///// <summary>
        ///// 网页描述
        ///// </summary>
        ///// <value></value>
        //[Keyword(Index = false)]
        //public string Description { get; set; }
    }
}
