using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Gbxx.WebApi.Requests.Query {
    /// <summary>
    /// 站点访问参数
    /// </summary>
    [BindProperties(SupportsGet = true)]
    public class SiteAccessGet {
        /// <summary>
        /// 源域名（Referrer,referer）
        /// </summary>
        public string Referrer { get; set; }
        /// <summary>
        /// 访问唯一标识（后期处理访问限制，IP、时间戳、设备等混合生成的标识）
        /// </summary>
        public string Unique { get; set; }
        /// <summary>
        /// 渠道
        /// </summary>
        public string From { get; set; }

    }
    /// <summary>
    /// 
    /// </summary>
    public class SiteAccessGetValidator : AbstractValidator<SiteAccessGet> {
        /// <summary>
        /// 
        /// </summary>
        public SiteAccessGetValidator() {

        }
    }
}
