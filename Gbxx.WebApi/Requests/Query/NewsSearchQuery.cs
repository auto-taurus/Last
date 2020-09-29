using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Requests.Query {
    /// <summary>
    /// 新闻检索
    /// </summary>
    public class NewsSearchQuery : QueryPager {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
    }
}
