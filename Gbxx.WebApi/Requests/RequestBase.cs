using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Requests {
    /// <summary>
    /// 基础信息
    /// </summary>
    public class RequestBase {
        /// <summary>
        /// 来源ip
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 设备号
        /// </summary>
        public string Device { get; set; }
        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }
    }
}
