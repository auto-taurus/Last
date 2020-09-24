using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Requests {
    /// <summary>
    /// 查询分页
    /// </summary>
    public class QueryPager : QueryBase {
        /// <summary>
        /// 查询分页
        /// </summary>
        public QueryPager() {
            this.PageIndex = 1;
            this.PageSize = 10;
        }
        /// <summary>
        /// 当前页
        /// </summary>
        public int? PageIndex { get; set; }
        /// <summary>
        /// 页大小
        /// </summary>
        public int? PageSize { get; set; }
    }
}
