using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.RedisServices.Modals {
    public class JwtAuthorData {
        /// <summary>
        /// 用户主键
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// 授权时间
        /// </summary>
        public long Auths { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public long Expires { get; set; }
        /// <summary>
        /// Token
        /// </summary>
        public string Token { get; set; }
    }
}
