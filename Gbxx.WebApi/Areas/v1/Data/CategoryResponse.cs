using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Data {
    /// <summary>
    /// 分类信息
    /// </summary>
    public class CategoryResponse {
        ///<summary>
        /// 栏目编号
        ///</summary>
        public int? CategoryId { get; set; }
        ///<summary>
        /// 栏目名称
        ///</summary>
        public string CategoryName { get; set; }
        ///<summary>
        /// 父级栏目编号
        ///</summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// 控制器
        /// </summary>
        public string Controller { get; set; }
        /// <summary>
        /// 动作
        /// </summary>
        public string Action { get; set; }
        ///<summary>
        /// 访问地址
        ///</summary>
        public string Urls { get; set; }
        ///<summary>
        /// 网页标题
        ///</summary>
        public string Title { get; set; }
        ///<summary>
        /// 网页关键字
        ///</summary>
        public string Keywords { get; set; }
        ///<summary>
        /// 网页描述
        ///</summary>
        public string Description { get; set; }
    }
}
