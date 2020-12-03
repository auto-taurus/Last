using Auto.Commons.ApiHandles.Requests;

namespace Gbxx.BackStage.Requests.Query {
    /// <summary>
    /// 系统用户查询实体
    /// </summary>
    public class SystemUsersQuery : RequestBase {
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int? IsEnable { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string MobilePhone { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
    }
}
