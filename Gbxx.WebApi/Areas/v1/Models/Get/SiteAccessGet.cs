using Auto.Commons.ApiHandles.Requests;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Requests.Query {
    /// <summary>
    /// 站点访问参数
    /// </summary>
    [BindProperties(SupportsGet = true)]
    public class SiteAccessGet : RequestBase {
        /// <summary>
        /// 源域名（Referrer,referer）
        /// </summary>
        public string Referrer { get; set; }
        /// <summary>
        /// 站点唯一标识
        /// </summary>
        public string Unique { get; set; }
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
