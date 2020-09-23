using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Dto.RedisDto {
    /// <summary>
    /// 
    /// </summary>
    public class SiteDto {
        /// <summary>
        /// 站点编号
        /// </summary>
        public int? SiteId { get; set; }
        ///<summary>
        /// 站点标识
        ///</summary>
        public int? Mark { get; set; }
        /// <summary>
        /// 站点名称
        /// </summary>
        public string SiteName { get; set; }
        /// <summary>
        /// 站点访问地址
        /// </summary>
        public string SiteUrls { get; set; }
        /// <summary>
        /// 站点Logo地址
        /// </summary>
        public string LogoUrls { get; set; }
        /// <summary>
        ///  网页标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        ///  网页关键字
        /// </summary>
        public string Keywords { get; set; }
        /// <summary>
        ///  网页描述
        /// </summary>
        public string Description { get; set; }
    }
}
