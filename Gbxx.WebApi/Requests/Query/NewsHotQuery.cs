using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Requests.Query {
    /// <summary>
    /// 热门查询
    /// </summary>
    public class NewsHotQuery : QueryPager {
        /// <summary>
        /// 天数
        /// </summary>
        public int? Days { get; set; }
    }
}
