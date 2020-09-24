using Gbxx.WebApi.Requests;

namespace Gbxx.WebApi.Areas.v1.Models.Get {
    /// <summary>
    /// 站点访问参数
    /// </summary>
    public class GetSiteAccess : GetBase {
        /// <summary>
        /// 源域名（Referrer,referer）
        /// </summary>
        public string Referrer { get; set; }
        /// <summary>
        /// 唯一标识
        /// </summary>
        public string Unique { get; set; }

    }
}
