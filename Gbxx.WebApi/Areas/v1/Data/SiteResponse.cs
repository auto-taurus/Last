using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Data {
    /// <summary>
    /// 站点信息
    /// </summary>
    public class SiteResponse {
        /// <summary>
        /// 站点编号
        /// </summary>
        public int? SiteId { get; set; }
        /// <summary>
        /// 站点名称
        /// </summary>
        public string SiteName { get; set; }
        /// <summary>
        /// 站点域名
        /// </summary>
        public string SiteUrls { get; set; }
        /// <summary>
        /// 站点Logo
        /// </summary>
        public string LogoUrls { get; set; }
        /// <summary>
        /// 网页标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 网页关键字
        /// </summary>
        public string Keywords { get; set; }
        /// <summary>
        /// 网页描述
        /// </summary>
        public string Description { get; set; }
    }
}
