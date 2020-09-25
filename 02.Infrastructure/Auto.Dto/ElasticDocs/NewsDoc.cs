using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Dto.ElasticDoc {

    [ElasticsearchType(IdProperty = "NewsId")]
    public class NewsDoc {
        /// <summary>
        /// 新闻编号
        /// </summary>
        /// <value></value>
        [LongRange(Index = true)]
        public int? NewsId { get; set; }
        /// <summary>
        /// 分类编号
        /// </summary>
        /// <value></value>
        [IntegerRange(Index = true)]
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
        [Text(Index = true)]
        public string NewsTitle { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        /// <value></value>
        [Text(Index = true)]
        public string Source { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        /// <value></value>
        [Text(Index = true)]
        public string Tags { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        /// <value></value>
        [Text(Index = true)]
        public string Contents { get; set; }
        /// <summary>
        /// 访问地址
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
        /// <value>0默认，1置顶，2大标，3推荐</value>
        [IntegerRange(Index = true)]
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
        [IntegerRange(Index = true)]
        public int? AccessCount { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        //[Date(Index = true)]
        [IntegerRange(Index = true)]
        public DateTime? PushTime { get; set; }
        /// <summary>
        /// 网页标题
        /// </summary>
        /// <value></value>
        public string Title { get; set; }
        /// <summary>
        /// 网页关键字
        /// </summary>
        /// <value></value>
        public string Keywords { get; set; }
        /// <summary>
        /// 网页描述
        /// </summary>
        /// <value></value>
        public string Description { get; set; }
    }
}
