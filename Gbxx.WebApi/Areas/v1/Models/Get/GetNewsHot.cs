using Gbxx.WebApi.Requests;

namespace Gbxx.WebApi.Areas.v1.Models.Get {
    /// <summary>
    /// 热门查询
    /// </summary>
    public class GetNewsHot : GetPager {
        /// <summary>
        /// 天数
        /// </summary>
        public int? Days { get; set; }
    }
}
