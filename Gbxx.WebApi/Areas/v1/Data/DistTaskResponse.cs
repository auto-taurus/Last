using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Data {
    public class DistTaskResponse {
        /// <summary>
        /// 实际使用Key
        /// </summary>
        public String DistKey { get; set; }
        /// <summary>
        /// 中文显示名称
        /// </summary>
        public String DistName { get; set; }
        /// <summary>
        /// 金币
        /// </summary>
        public int Beans { get; set; }
    }
}
