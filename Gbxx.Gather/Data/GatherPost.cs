using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.Gather.Data {
    public class GatherPost {
        /// <summary>
        /// 站点标识
        /// </summary>
        public int? site_id { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string cate_name { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public string tag { get; set; }
        /// <summary>
        /// 来源名称
        /// </summary>
        public string from { get; set; }
        /// <summary>
        /// 来源Logo
        /// </summary>
        public string from_pic { get; set; }
        /// <summary>
        /// ImageHost
        /// </summary>
        public string image_host { get; set; }
        /// <summary>
        /// 缩略图
        /// </summary>
        public string thumbpic { get; set; }
        /// <summary>
        /// 网页关键字
        /// </summary>
        public string search_word { get; set; }
    }
}
