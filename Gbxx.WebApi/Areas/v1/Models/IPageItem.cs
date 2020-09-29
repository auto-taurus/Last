using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Models {
    /// <summary>
    /// 
    /// </summary>
    public interface IPageItem {
        /// <summary>
        /// 当前页
        /// </summary>
        String PageIndex { get; set; }
        /// <summary>
        /// 页大小
        /// </summary>
        int? PageSize { get; set; }
    }
}
