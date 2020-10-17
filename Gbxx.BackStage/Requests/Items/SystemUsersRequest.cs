using Auto.Entities.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.BackStage.Requests.Items {
    public class SystemUsersRequest {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UsersId { get; set; }
        /// <summary>
        /// 真实名
        /// </summary>
        public string UsersName { get; set; }
        /// <summary>
        /// 登录名
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 移动电话
        /// </summary>
        public string MobilePhone { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 登录IP
        /// </summary>
        public string LoginIp { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime? LoginTime { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int? IsEnable { get; set; }
        /// <summary>
        /// 备注/自定义描述
        /// </summary>
        public string Remarks { get; set; }
    }
    public static class SystemUsersRequestExts {
        public static SystemUsers ToEntity(this SystemUsersRequest request) {
            return new SystemUsers {
                UsersId = request.UsersId,
                UsersName = request.UsersName,
                LoginName = request.LoginName,
                Password = request.Password,
                MobilePhone = request.MobilePhone,
                Email = request.Email,
                LoginIp = request.LoginIp,
                LoginTime = request.LoginTime,
                IsEnable = request.IsEnable,
                Remarks = request.Remarks
            };
        }
    }
}
