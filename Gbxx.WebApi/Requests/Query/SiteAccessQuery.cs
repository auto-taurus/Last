using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Requests.Query {
    /// <summary>
    /// 站点访问参数
    /// </summary>
    public class SiteAccessQuery : RequestBase {
        /// <summary>
        /// 源域名（Referrer,referer）
        /// </summary>
        public string Referrer { get; set; }
        /// <summary>
        /// 站点唯一标识
        /// </summary>
        public string Unique { get; set; }

    }
}
