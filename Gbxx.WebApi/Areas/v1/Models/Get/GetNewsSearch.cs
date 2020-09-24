using Gbxx.WebApi.Requests;

namespace Gbxx.WebApi.Areas.v1.Models.Get {
    /// <summary>
    /// 新闻检索
    /// </summary>
    public class GetNewsSearch : GetPager {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
    }
}
